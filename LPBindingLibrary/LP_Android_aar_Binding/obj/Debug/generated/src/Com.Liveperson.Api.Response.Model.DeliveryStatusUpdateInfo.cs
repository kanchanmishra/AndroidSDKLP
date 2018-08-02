using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='DeliveryStatusUpdateInfo']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/DeliveryStatusUpdateInfo", DoNotGenerateAcw=true)]
	public partial class DeliveryStatusUpdateInfo : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/DeliveryStatusUpdateInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeliveryStatusUpdateInfo); }
		}

		protected DeliveryStatusUpdateInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONArray_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='DeliveryStatusUpdateInfo']/constructor[@name='DeliveryStatusUpdateInfo' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register (".ctor", "(Lorg/json/JSONArray;)V", "")]
		public unsafe DeliveryStatusUpdateInfo (global::Org.Json.JSONArray p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (DeliveryStatusUpdateInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONArray;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONArray;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONArray_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONArray;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONArray_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONArray_, __args);
			} finally {
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.DeliveryStatusUpdateInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.DeliveryStatusUpdateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		public virtual unsafe global::Org.Json.JSONArray Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='DeliveryStatusUpdateInfo']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lorg/json/JSONArray;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Lorg/json/JSONArray;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadata", "()Lorg/json/JSONArray;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
