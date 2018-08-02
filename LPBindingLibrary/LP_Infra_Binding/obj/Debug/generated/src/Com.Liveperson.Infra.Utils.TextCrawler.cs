using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/TextCrawler", DoNotGenerateAcw=true)]
	public partial class TextCrawler : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler']/field[@name='TIMEOUT_IN_MILLI']"
		[Register ("TIMEOUT_IN_MILLI")]
		public const int TimeoutInMilli = (int) 1500;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler.GetCode']"
		[global::Android.Runtime.Register ("com/liveperson/infra/utils/TextCrawler$GetCode", DoNotGenerateAcw=true)]
		public partial class GetCode : global::Android.OS.AsyncTask {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/utils/TextCrawler$GetCode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GetCode); }
			}

			protected GetCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_isNull;
#pragma warning disable 0169
			static Delegate GetIsNullHandler ()
			{
				if (cb_isNull == null)
					cb_isNull = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNull);
				return cb_isNull;
			}

			static bool n_IsNull (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Utils.TextCrawler.GetCode __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.TextCrawler.GetCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsNull;
			}
#pragma warning restore 0169

			static IntPtr id_isNull;
			public virtual unsafe bool IsNull {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler.GetCode']/method[@name='isNull' and count(parameter)=0]"
				[Register ("isNull", "()Z", "GetIsNullHandler")]
				get {
					if (id_isNull == IntPtr.Zero)
						id_isNull = JNIEnv.GetMethodID (class_ref, "isNull", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNull);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNull", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_String_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_String_ == null)
					cb_doInBackground_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_String_);
				return cb_doInBackground_arrayLjava_lang_String_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Utils.TextCrawler.GetCode __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.TextCrawler.GetCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler.GetCode']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
			[Register ("doInBackground", "([Ljava/lang/String;)Ljava/lang/Void;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
			protected virtual unsafe global::Java.Lang.Void DoInBackground (params  string[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/String;)Ljava/lang/Void;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Void __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/String;)Ljava/lang/Void;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_onPostExecute_Ljava_lang_Void_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_lang_Void_Handler ()
			{
				if (cb_onPostExecute_Ljava_lang_Void_ == null)
					cb_onPostExecute_Ljava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Void_);
				return cb_onPostExecute_Ljava_lang_Void_;
			}

			static void n_OnPostExecute_Ljava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Utils.TextCrawler.GetCode __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.TextCrawler.GetCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Void p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Void> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_Ljava_lang_Void_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler.GetCode']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Void']]"
			[Register ("onPostExecute", "(Ljava/lang/Void;)V", "GetOnPostExecute_Ljava_lang_Void_Handler")]
			protected virtual unsafe void OnPostExecute (global::Java.Lang.Void p0)
			{
				if (id_onPostExecute_Ljava_lang_Void_ == IntPtr.Zero)
					id_onPostExecute_Ljava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Void;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostExecute_Ljava_lang_Void_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Void;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/TextCrawler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextCrawler); }
		}

		protected TextCrawler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler']/constructor[@name='TextCrawler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextCrawler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TextCrawler)) {
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

		static Delegate cb_getSourceContent;
#pragma warning disable 0169
		static Delegate GetGetSourceContentHandler ()
		{
			if (cb_getSourceContent == null)
				cb_getSourceContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSourceContent);
			return cb_getSourceContent;
		}

		static IntPtr n_GetSourceContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.TextCrawler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.TextCrawler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SourceContent);
		}
#pragma warning restore 0169

		static IntPtr id_getSourceContent;
		public virtual unsafe global::Com.Liveperson.Infra.Utils.SourceContent SourceContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler']/method[@name='getSourceContent' and count(parameter)=0]"
			[Register ("getSourceContent", "()Lcom/liveperson/infra/utils/SourceContent;", "GetGetSourceContentHandler")]
			get {
				if (id_getSourceContent == IntPtr.Zero)
					id_getSourceContent = JNIEnv.GetMethodID (class_ref, "getSourceContent", "()Lcom/liveperson/infra/utils/SourceContent;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSourceContent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSourceContent", "()Lcom/liveperson/infra/utils/SourceContent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_makePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMakePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_Handler ()
		{
			if (cb_makePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_ == null)
				cb_makePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_);
			return cb_makePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_;
		}

		static void n_MakePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Utils.TextCrawler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.TextCrawler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback p0 = (global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MakePreview (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_makePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler']/method[@name='makePreview' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.utils.LinkPreviewCallback'] and parameter[2][@type='java.lang.String']]"
		[Register ("makePreview", "(Lcom/liveperson/infra/utils/LinkPreviewCallback;Ljava/lang/String;)V", "GetMakePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_Handler")]
		public virtual unsafe void MakePreview (global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback p0, string p1)
		{
			if (id_makePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_makePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "makePreview", "(Lcom/liveperson/infra/utils/LinkPreviewCallback;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_makePreview_Lcom_liveperson_infra_utils_LinkPreviewCallback_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makePreview", "(Lcom/liveperson/infra/utils/LinkPreviewCallback;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_parseHtml_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseHtml_arrayLjava_lang_String_Handler ()
		{
			if (cb_parseHtml_arrayLjava_lang_String_ == null)
				cb_parseHtml_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseHtml_arrayLjava_lang_String_);
			return cb_parseHtml_arrayLjava_lang_String_;
		}

		static void n_ParseHtml_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.TextCrawler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.TextCrawler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.ParseHtml (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_parseHtml_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='TextCrawler']/method[@name='parseHtml' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("parseHtml", "([Ljava/lang/String;)V", "GetParseHtml_arrayLjava_lang_String_Handler")]
		public virtual unsafe void ParseHtml (string[] p0)
		{
			if (id_parseHtml_arrayLjava_lang_String_ == IntPtr.Zero)
				id_parseHtml_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parseHtml", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseHtml_arrayLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseHtml", "([Ljava/lang/String;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
