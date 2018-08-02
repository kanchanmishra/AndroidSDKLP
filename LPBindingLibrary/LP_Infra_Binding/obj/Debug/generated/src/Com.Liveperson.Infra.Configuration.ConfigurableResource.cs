using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource']"
	[global::Android.Runtime.Register ("com/liveperson/infra/configuration/ConfigurableResource", DoNotGenerateAcw=true)]
	public partial class ConfigurableResource : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource.ResourceType']"
		[global::Android.Runtime.Register ("com/liveperson/infra/configuration/ConfigurableResource$ResourceType", DoNotGenerateAcw=true)]
		public sealed partial class ResourceType : global::Java.Lang.Enum {


			static IntPtr Boolean_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource.ResourceType']/field[@name='Boolean']"
			[Register ("Boolean")]
			public static global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType Boolean {
				get {
					if (Boolean_jfieldId == IntPtr.Zero)
						Boolean_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Boolean", "Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Boolean_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Color_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource.ResourceType']/field[@name='Color']"
			[Register ("Color")]
			public static global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType Color {
				get {
					if (Color_jfieldId == IntPtr.Zero)
						Color_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Color", "Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Color_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Dimension_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource.ResourceType']/field[@name='Dimension']"
			[Register ("Dimension")]
			public static global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType Dimension {
				get {
					if (Dimension_jfieldId == IntPtr.Zero)
						Dimension_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Dimension", "Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Dimension_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Integer_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource.ResourceType']/field[@name='Integer']"
			[Register ("Integer")]
			public static global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType Integer {
				get {
					if (Integer_jfieldId == IntPtr.Zero)
						Integer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Integer", "Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Integer_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource.ResourceType']/field[@name='Unknown']"
			[Register ("Unknown")]
			public static global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType Unknown {
				get {
					if (Unknown_jfieldId == IntPtr.Zero)
						Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unknown", "Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/configuration/ConfigurableResource$ResourceType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ResourceType); }
			}

			internal ResourceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource.ResourceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;", "")]
			public static unsafe global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource.ResourceType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;", "")]
			public static unsafe global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;");
				try {
					return (global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/configuration/ConfigurableResource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigurableResource); }
		}

		protected ConfigurableResource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Lcom_liveperson_infra_configuration_ConfigurableResource_ResourceType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource']/constructor[@name='ConfigurableResource' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.configuration.ConfigurableResource.ResourceType']]"
		[Register (".ctor", "(ILjava/lang/String;Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;)V", "")]
		public unsafe ConfigurableResource (int p0, string p1, global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ConfigurableResource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Lcom_liveperson_infra_configuration_ConfigurableResource_ResourceType_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Lcom_liveperson_infra_configuration_ConfigurableResource_ResourceType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Lcom_liveperson_infra_configuration_ConfigurableResource_ResourceType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_Lcom_liveperson_infra_configuration_ConfigurableResource_ResourceType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getResourceId;
#pragma warning disable 0169
		static Delegate GetGetResourceIdHandler ()
		{
			if (cb_getResourceId == null)
				cb_getResourceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResourceId);
			return cb_getResourceId;
		}

		static int n_GetResourceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Configuration.ConfigurableResource __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResourceId;
		}
#pragma warning restore 0169

		static IntPtr id_getResourceId;
		public virtual unsafe int ResourceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource']/method[@name='getResourceId' and count(parameter)=0]"
			[Register ("getResourceId", "()I", "GetGetResourceIdHandler")]
			get {
				if (id_getResourceId == IntPtr.Zero)
					id_getResourceId = JNIEnv.GetMethodID (class_ref, "getResourceId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getResourceId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getResourceName;
#pragma warning disable 0169
		static Delegate GetGetResourceNameHandler ()
		{
			if (cb_getResourceName == null)
				cb_getResourceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceName);
			return cb_getResourceName;
		}

		static IntPtr n_GetResourceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Configuration.ConfigurableResource __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResourceName);
		}
#pragma warning restore 0169

		static IntPtr id_getResourceName;
		public virtual unsafe string ResourceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource']/method[@name='getResourceName' and count(parameter)=0]"
			[Register ("getResourceName", "()Ljava/lang/String;", "GetGetResourceNameHandler")]
			get {
				if (id_getResourceName == IntPtr.Zero)
					id_getResourceName = JNIEnv.GetMethodID (class_ref, "getResourceName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResourceType;
#pragma warning disable 0169
		static Delegate GetGetResourceTypeHandler ()
		{
			if (cb_getResourceType == null)
				cb_getResourceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceType);
			return cb_getResourceType;
		}

		static IntPtr n_GetResourceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Configuration.ConfigurableResource __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetResourceType ());
		}
#pragma warning restore 0169

		static IntPtr id_getResourceType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='ConfigurableResource']/method[@name='getResourceType' and count(parameter)=0]"
		[Register ("getResourceType", "()Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;", "GetGetResourceTypeHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType GetResourceType ()
		{
			if (id_getResourceType == IntPtr.Zero)
				id_getResourceType = JNIEnv.GetMethodID (class_ref, "getResourceType", "()Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Configuration.ConfigurableResource.ResourceType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceType", "()Lcom/liveperson/infra/configuration/ConfigurableResource$ResourceType;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
