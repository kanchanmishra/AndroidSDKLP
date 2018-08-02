using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='QueryParams']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/QueryParams", DoNotGenerateAcw=true)]
	public partial class QueryParams : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='QueryParams']/field[@name='EXPIRE_TIME']"
		[Register ("EXPIRE_TIME")]
		public const string ExpireTime = (string) "temp_url_expires";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='QueryParams']/field[@name='TEMP_URL']"
		[Register ("TEMP_URL")]
		public const string TempUrl = (string) "temp_url_sig";

		static IntPtr tempURL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='QueryParams']/field[@name='tempURL']"
		[Register ("tempURL")]
		public string TempURL {
			get {
				if (tempURL_jfieldId == IntPtr.Zero)
					tempURL_jfieldId = JNIEnv.GetFieldID (class_ref, "tempURL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tempURL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tempURL_jfieldId == IntPtr.Zero)
					tempURL_jfieldId = JNIEnv.GetFieldID (class_ref, "tempURL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tempURL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/QueryParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueryParams); }
		}

		protected QueryParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='QueryParams']/constructor[@name='QueryParams' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe QueryParams (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (QueryParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static Delegate cb_appendQueryParameter_Landroid_net_Uri_Builder_;
#pragma warning disable 0169
		static Delegate GetAppendQueryParameter_Landroid_net_Uri_Builder_Handler ()
		{
			if (cb_appendQueryParameter_Landroid_net_Uri_Builder_ == null)
				cb_appendQueryParameter_Landroid_net_Uri_Builder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AppendQueryParameter_Landroid_net_Uri_Builder_);
			return cb_appendQueryParameter_Landroid_net_Uri_Builder_;
		}

		static void n_AppendQueryParameter_Landroid_net_Uri_Builder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Api.Response.Model.QueryParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.QueryParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri.Builder p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppendQueryParameter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_appendQueryParameter_Landroid_net_Uri_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='QueryParams']/method[@name='appendQueryParameter' and count(parameter)=1 and parameter[1][@type='android.net.Uri.Builder']]"
		[Register ("appendQueryParameter", "(Landroid/net/Uri$Builder;)V", "GetAppendQueryParameter_Landroid_net_Uri_Builder_Handler")]
		public virtual unsafe void AppendQueryParameter (global::Android.Net.Uri.Builder p0)
		{
			if (id_appendQueryParameter_Landroid_net_Uri_Builder_ == IntPtr.Zero)
				id_appendQueryParameter_Landroid_net_Uri_Builder_ = JNIEnv.GetMethodID (class_ref, "appendQueryParameter", "(Landroid/net/Uri$Builder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_appendQueryParameter_Landroid_net_Uri_Builder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "appendQueryParameter", "(Landroid/net/Uri$Builder;)V"), __args);
			} finally {
			}
		}

	}
}
