using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']"
	[global::Android.Runtime.Register ("com/liveperson/sdk/MonitoringParams", DoNotGenerateAcw=true)]
	public sealed partial class MonitoringParams : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/sdk/MonitoringParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MonitoringParams); }
		}

		internal MonitoringParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/constructor[@name='MonitoringParams' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray'] and parameter[3][@type='org.json.JSONArray']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/json/JSONArray;)V", "")]
		public unsafe MonitoringParams (string p0, global::Org.Json.JSONArray p1, global::Org.Json.JSONArray p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MonitoringParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/json/JSONArray;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/json/JSONArray;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/json/JSONArray;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/constructor[@name='MonitoringParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MonitoringParams ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MonitoringParams)) {
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

		static IntPtr id_getEngagementAttributes;
		public unsafe global::Org.Json.JSONArray EngagementAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/method[@name='getEngagementAttributes' and count(parameter)=0]"
			[Register ("getEngagementAttributes", "()Lorg/json/JSONArray;", "GetGetEngagementAttributesHandler")]
			get {
				if (id_getEngagementAttributes == IntPtr.Zero)
					id_getEngagementAttributes = JNIEnv.GetMethodID (class_ref, "getEngagementAttributes", "()Lorg/json/JSONArray;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEngagementAttributes), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getEntryPoints;
		public unsafe global::Org.Json.JSONArray EntryPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/method[@name='getEntryPoints' and count(parameter)=0]"
			[Register ("getEntryPoints", "()Lorg/json/JSONArray;", "GetGetEntryPointsHandler")]
			get {
				if (id_getEntryPoints == IntPtr.Zero)
					id_getEntryPoints = JNIEnv.GetMethodID (class_ref, "getEntryPoints", "()Lorg/json/JSONArray;");
				try {
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntryPoints), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPageId;
		public unsafe string PageId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/method[@name='getPageId' and count(parameter)=0]"
			[Register ("getPageId", "()Ljava/lang/String;", "GetGetPageIdHandler")]
			get {
				if (id_getPageId == IntPtr.Zero)
					id_getPageId = JNIEnv.GetMethodID (class_ref, "getPageId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPageId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_component1;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			if (id_component1 == IntPtr.Zero)
				id_component1 = JNIEnv.GetMethodID (class_ref, "component1", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_component1), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_component2;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lorg/json/JSONArray;", "")]
		public unsafe global::Org.Json.JSONArray Component2 ()
		{
			if (id_component2 == IntPtr.Zero)
				id_component2 = JNIEnv.GetMethodID (class_ref, "component2", "()Lorg/json/JSONArray;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_component2), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_component3;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Lorg/json/JSONArray;", "")]
		public unsafe global::Org.Json.JSONArray Component3 ()
		{
			if (id_component3 == IntPtr.Zero)
				id_component3 = JNIEnv.GetMethodID (class_ref, "component3", "()Lorg/json/JSONArray;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_component3), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_copy_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.sdk']/class[@name='MonitoringParams']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.json.JSONArray'] and parameter[3][@type='org.json.JSONArray']]"
		[Register ("copy", "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/json/JSONArray;)Lcom/liveperson/sdk/MonitoringParams;", "")]
		public unsafe global::Com.Liveperson.Sdk.MonitoringParams Copy (string p0, global::Org.Json.JSONArray p1, global::Org.Json.JSONArray p2)
		{
			if (id_copy_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_copy_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "copy", "(Ljava/lang/String;Lorg/json/JSONArray;Lorg/json/JSONArray;)Lcom/liveperson/sdk/MonitoringParams;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Liveperson.Sdk.MonitoringParams __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Sdk.MonitoringParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy_Ljava_lang_String_Lorg_json_JSONArray_Lorg_json_JSONArray_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
