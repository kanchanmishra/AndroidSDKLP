using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/MultiDialog", DoNotGenerateAcw=true)]
	public abstract partial class MultiDialog : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog.ChannelTypes']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/model/MultiDialog$ChannelTypes", DoNotGenerateAcw=true)]
		public sealed partial class ChannelTypes : global::Java.Lang.Enum {


			static IntPtr COBROWSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog.ChannelTypes']/field[@name='COBROWSE']"
			[Register ("COBROWSE")]
			public static global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes Cobrowse {
				get {
					if (COBROWSE_jfieldId == IntPtr.Zero)
						COBROWSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COBROWSE", "Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COBROWSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MESSAGING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog.ChannelTypes']/field[@name='MESSAGING']"
			[Register ("MESSAGING")]
			public static global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes Messaging {
				get {
					if (MESSAGING_jfieldId == IntPtr.Zero)
						MESSAGING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MESSAGING", "Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MESSAGING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/model/MultiDialog$ChannelTypes", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ChannelTypes); }
			}

			internal ChannelTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog.ChannelTypes']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog.ChannelTypes']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;");
				try {
					return (global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/MultiDialog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiDialog); }
		}

		protected MultiDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog']/constructor[@name='MultiDialog' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe MultiDialog (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MultiDialog)) {
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Response.Model.MultiDialog __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.MultiDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.MultiDialog.ChannelTypes> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/liveperson/api/response/model/MultiDialog$ChannelTypes;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_create_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='MultiDialog']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("create", "(Lorg/json/JSONObject;)Lcom/liveperson/api/response/model/Dialog;", "")]
		public static unsafe global::Com.Liveperson.Api.Response.Model.Dialog Create (global::Org.Json.JSONObject p0)
		{
			if (id_create_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_create_Lorg_json_JSONObject_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lorg/json/JSONObject;)Lcom/liveperson/api/response/model/Dialog;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Api.Response.Model.Dialog __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Dialog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lorg_json_JSONObject_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/api/response/model/MultiDialog", DoNotGenerateAcw=true)]
	internal partial class MultiDialogInvoker : MultiDialog {

		public MultiDialogInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiDialogInvoker); }
		}

	}

}
