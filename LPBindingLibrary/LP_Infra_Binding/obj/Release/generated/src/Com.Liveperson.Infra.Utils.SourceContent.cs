using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/SourceContent", DoNotGenerateAcw=true)]
	public partial class SourceContent : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/SourceContent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SourceContent); }
		}

		protected SourceContent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/constructor[@name='SourceContent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SourceContent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SourceContent)) {
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

		static Delegate cb_getCannonicalUrl;
#pragma warning disable 0169
		static Delegate GetGetCannonicalUrlHandler ()
		{
			if (cb_getCannonicalUrl == null)
				cb_getCannonicalUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCannonicalUrl);
			return cb_getCannonicalUrl;
		}

		static IntPtr n_GetCannonicalUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CannonicalUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setCannonicalUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCannonicalUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setCannonicalUrl_Ljava_lang_String_ == null)
				cb_setCannonicalUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCannonicalUrl_Ljava_lang_String_);
			return cb_setCannonicalUrl_Ljava_lang_String_;
		}

		static void n_SetCannonicalUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CannonicalUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCannonicalUrl;
		static IntPtr id_setCannonicalUrl_Ljava_lang_String_;
		public virtual unsafe string CannonicalUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getCannonicalUrl' and count(parameter)=0]"
			[Register ("getCannonicalUrl", "()Ljava/lang/String;", "GetGetCannonicalUrlHandler")]
			get {
				if (id_getCannonicalUrl == IntPtr.Zero)
					id_getCannonicalUrl = JNIEnv.GetMethodID (class_ref, "getCannonicalUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCannonicalUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCannonicalUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setCannonicalUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCannonicalUrl", "(Ljava/lang/String;)V", "GetSetCannonicalUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setCannonicalUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setCannonicalUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCannonicalUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCannonicalUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCannonicalUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setDescription_Ljava_lang_String_ == null)
				cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Ljava_lang_String_);
			return cb_setDescription_Ljava_lang_String_;
		}

		static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Description = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		static IntPtr id_setDescription_Ljava_lang_String_;
		public virtual unsafe string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDescription_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFinalUrl;
#pragma warning disable 0169
		static Delegate GetGetFinalUrlHandler ()
		{
			if (cb_getFinalUrl == null)
				cb_getFinalUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFinalUrl);
			return cb_getFinalUrl;
		}

		static IntPtr n_GetFinalUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FinalUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setFinalUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFinalUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setFinalUrl_Ljava_lang_String_ == null)
				cb_setFinalUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFinalUrl_Ljava_lang_String_);
			return cb_setFinalUrl_Ljava_lang_String_;
		}

		static void n_SetFinalUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FinalUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFinalUrl;
		static IntPtr id_setFinalUrl_Ljava_lang_String_;
		public virtual unsafe string FinalUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getFinalUrl' and count(parameter)=0]"
			[Register ("getFinalUrl", "()Ljava/lang/String;", "GetGetFinalUrlHandler")]
			get {
				if (id_getFinalUrl == IntPtr.Zero)
					id_getFinalUrl = JNIEnv.GetMethodID (class_ref, "getFinalUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFinalUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFinalUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setFinalUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFinalUrl", "(Ljava/lang/String;)V", "GetSetFinalUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setFinalUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setFinalUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFinalUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFinalUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFinalUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHtmlCode;
#pragma warning disable 0169
		static Delegate GetGetHtmlCodeHandler ()
		{
			if (cb_getHtmlCode == null)
				cb_getHtmlCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHtmlCode);
			return cb_getHtmlCode;
		}

		static IntPtr n_GetHtmlCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HtmlCode);
		}
#pragma warning restore 0169

		static Delegate cb_setHtmlCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHtmlCode_Ljava_lang_String_Handler ()
		{
			if (cb_setHtmlCode_Ljava_lang_String_ == null)
				cb_setHtmlCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHtmlCode_Ljava_lang_String_);
			return cb_setHtmlCode_Ljava_lang_String_;
		}

		static void n_SetHtmlCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HtmlCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHtmlCode;
		static IntPtr id_setHtmlCode_Ljava_lang_String_;
		public virtual unsafe string HtmlCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getHtmlCode' and count(parameter)=0]"
			[Register ("getHtmlCode", "()Ljava/lang/String;", "GetGetHtmlCodeHandler")]
			get {
				if (id_getHtmlCode == IntPtr.Zero)
					id_getHtmlCode = JNIEnv.GetMethodID (class_ref, "getHtmlCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHtmlCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHtmlCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setHtmlCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHtmlCode", "(Ljava/lang/String;)V", "GetSetHtmlCode_Ljava_lang_String_Handler")]
			set {
				if (id_setHtmlCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setHtmlCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHtmlCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHtmlCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHtmlCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getImages;
#pragma warning disable 0169
		static Delegate GetGetImagesHandler ()
		{
			if (cb_getImages == null)
				cb_getImages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImages);
			return cb_getImages;
		}

		static IntPtr n_GetImages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Images);
		}
#pragma warning restore 0169

		static Delegate cb_setImages_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImages_Ljava_lang_String_Handler ()
		{
			if (cb_setImages_Ljava_lang_String_ == null)
				cb_setImages_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImages_Ljava_lang_String_);
			return cb_setImages_Ljava_lang_String_;
		}

		static void n_SetImages_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Images = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImages;
		static IntPtr id_setImages_Ljava_lang_String_;
		public virtual unsafe string Images {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getImages' and count(parameter)=0]"
			[Register ("getImages", "()Ljava/lang/String;", "GetGetImagesHandler")]
			get {
				if (id_getImages == IntPtr.Zero)
					id_getImages = JNIEnv.GetMethodID (class_ref, "getImages", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImages), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImages", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setImages' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImages", "(Ljava/lang/String;)V", "GetSetImages_Ljava_lang_String_Handler")]
			set {
				if (id_setImages_Ljava_lang_String_ == IntPtr.Zero)
					id_setImages_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImages", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImages_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImages", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMetaTags;
#pragma warning disable 0169
		static Delegate GetGetMetaTagsHandler ()
		{
			if (cb_getMetaTags == null)
				cb_getMetaTags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetaTags);
			return cb_getMetaTags;
		}

		static IntPtr n_GetMetaTags (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.MetaTags);
		}
#pragma warning restore 0169

		static Delegate cb_setMetaTags_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetSetMetaTags_Ljava_util_HashMap_Handler ()
		{
			if (cb_setMetaTags_Ljava_util_HashMap_ == null)
				cb_setMetaTags_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetaTags_Ljava_util_HashMap_);
			return cb_setMetaTags_Ljava_util_HashMap_;
		}

		static void n_SetMetaTags_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MetaTags = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetaTags;
		static IntPtr id_setMetaTags_Ljava_util_HashMap_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> MetaTags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getMetaTags' and count(parameter)=0]"
			[Register ("getMetaTags", "()Ljava/util/HashMap;", "GetGetMetaTagsHandler")]
			get {
				if (id_getMetaTags == IntPtr.Zero)
					id_getMetaTags = JNIEnv.GetMethodID (class_ref, "getMetaTags", "()Ljava/util/HashMap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetaTags), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetaTags", "()Ljava/util/HashMap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setMetaTags' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setMetaTags", "(Ljava/util/HashMap;)V", "GetSetMetaTags_Ljava_util_HashMap_Handler")]
			set {
				if (id_setMetaTags_Ljava_util_HashMap_ == IntPtr.Zero)
					id_setMetaTags_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setMetaTags", "(Ljava/util/HashMap;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMetaTags_Ljava_util_HashMap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetaTags", "(Ljava/util/HashMap;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRaw;
#pragma warning disable 0169
		static Delegate GetGetRawHandler ()
		{
			if (cb_getRaw == null)
				cb_getRaw = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRaw);
			return cb_getRaw;
		}

		static IntPtr n_GetRaw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Raw);
		}
#pragma warning restore 0169

		static Delegate cb_setRaw_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRaw_Ljava_lang_String_Handler ()
		{
			if (cb_setRaw_Ljava_lang_String_ == null)
				cb_setRaw_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRaw_Ljava_lang_String_);
			return cb_setRaw_Ljava_lang_String_;
		}

		static void n_SetRaw_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Raw = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRaw;
		static IntPtr id_setRaw_Ljava_lang_String_;
		public virtual unsafe string Raw {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getRaw' and count(parameter)=0]"
			[Register ("getRaw", "()Ljava/lang/String;", "GetGetRawHandler")]
			get {
				if (id_getRaw == IntPtr.Zero)
					id_getRaw = JNIEnv.GetMethodID (class_ref, "getRaw", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRaw), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRaw", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setRaw' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRaw", "(Ljava/lang/String;)V", "GetSetRaw_Ljava_lang_String_Handler")]
			set {
				if (id_setRaw_Ljava_lang_String_ == IntPtr.Zero)
					id_setRaw_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRaw", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRaw_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRaw", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSiteName;
#pragma warning disable 0169
		static Delegate GetGetSiteNameHandler ()
		{
			if (cb_getSiteName == null)
				cb_getSiteName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteName);
			return cb_getSiteName;
		}

		static IntPtr n_GetSiteName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteName);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSiteName_Ljava_lang_String_Handler ()
		{
			if (cb_setSiteName_Ljava_lang_String_ == null)
				cb_setSiteName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteName_Ljava_lang_String_);
			return cb_setSiteName_Ljava_lang_String_;
		}

		static void n_SetSiteName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SiteName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteName;
		static IntPtr id_setSiteName_Ljava_lang_String_;
		public virtual unsafe string SiteName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getSiteName' and count(parameter)=0]"
			[Register ("getSiteName", "()Ljava/lang/String;", "GetGetSiteNameHandler")]
			get {
				if (id_getSiteName == IntPtr.Zero)
					id_getSiteName = JNIEnv.GetMethodID (class_ref, "getSiteName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setSiteName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteName", "(Ljava/lang/String;)V", "GetSetSiteName_Ljava_lang_String_Handler")]
			set {
				if (id_setSiteName_Ljava_lang_String_ == IntPtr.Zero)
					id_setSiteName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSiteName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Success;
		}
#pragma warning restore 0169

		static Delegate cb_setSuccess_Z;
#pragma warning disable 0169
		static Delegate GetSetSuccess_ZHandler ()
		{
			if (cb_setSuccess_Z == null)
				cb_setSuccess_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSuccess_Z);
			return cb_setSuccess_Z;
		}

		static void n_SetSuccess_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Success = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSuccess;
		static IntPtr id_setSuccess_Z;
		public virtual unsafe bool Success {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccess);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccess", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setSuccess' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSuccess", "(Z)V", "GetSetSuccess_ZHandler")]
			set {
				if (id_setSuccess_Z == IntPtr.Zero)
					id_setSuccess_Z = JNIEnv.GetMethodID (class_ref, "setSuccess", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSuccess_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuccess", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		static IntPtr id_setUrl_Ljava_lang_String_;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUrlData;
#pragma warning disable 0169
		static Delegate GetGetUrlDataHandler ()
		{
			if (cb_getUrlData == null)
				cb_getUrlData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrlData);
			return cb_getUrlData;
		}

		static IntPtr n_GetUrlData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetUrlData ());
		}
#pragma warning restore 0169

		static IntPtr id_getUrlData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='getUrlData' and count(parameter)=0]"
		[Register ("getUrlData", "()[Ljava/lang/String;", "GetGetUrlDataHandler")]
		public virtual unsafe string[] GetUrlData ()
		{
			if (id_getUrlData == IntPtr.Zero)
				id_getUrlData = JNIEnv.GetMethodID (class_ref, "getUrlData", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrlData), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrlData", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setUrlData_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrlData_arrayLjava_lang_String_Handler ()
		{
			if (cb_setUrlData_arrayLjava_lang_String_ == null)
				cb_setUrlData_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrlData_arrayLjava_lang_String_);
			return cb_setUrlData_arrayLjava_lang_String_;
		}

		static void n_SetUrlData_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.SourceContent __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetUrlData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUrlData_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='SourceContent']/method[@name='setUrlData' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setUrlData", "([Ljava/lang/String;)V", "GetSetUrlData_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetUrlData (string[] p0)
		{
			if (id_setUrlData_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setUrlData_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrlData", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUrlData_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrlData", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
