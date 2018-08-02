using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Configuration {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']"
	[global::Android.Runtime.Register ("com/liveperson/infra/configuration/Configuration", DoNotGenerateAcw=true)]
	public partial class Configuration : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/configuration/Configuration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Configuration); }
		}

		protected Configuration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/constructor[@name='Configuration' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Configuration ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Configuration)) {
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

		static IntPtr id_getBoolean_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBoolean", "(I)Z", "")]
		public static unsafe bool GetBoolean (int p0)
		{
			if (id_getBoolean_I == IntPtr.Zero)
				id_getBoolean_I = JNIEnv.GetStaticMethodID (class_ref, "getBoolean", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_getBoolean_I, __args);
			} finally {
			}
		}

		static IntPtr id_getColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='getColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColor", "(I)I", "")]
		public static unsafe int GetColor (int p0)
		{
			if (id_getColor_I == IntPtr.Zero)
				id_getColor_I = JNIEnv.GetStaticMethodID (class_ref, "getColor", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getColor_I, __args);
			} finally {
			}
		}

		static IntPtr id_getDimension_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='getDimension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDimension", "(I)F", "")]
		public static unsafe float GetDimension (int p0)
		{
			if (id_getDimension_I == IntPtr.Zero)
				id_getDimension_I = JNIEnv.GetStaticMethodID (class_ref, "getDimension", "(I)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_getDimension_I, __args);
			} finally {
			}
		}

		static IntPtr id_getDrawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (int p0)
		{
			if (id_getDrawable_I == IntPtr.Zero)
				id_getDrawable_I = JNIEnv.GetStaticMethodID (class_ref, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDrawable_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getInteger_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='getInteger' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getInteger", "(I)I", "")]
		public static unsafe int GetInteger (int p0)
		{
			if (id_getInteger_I == IntPtr.Zero)
				id_getInteger_I = JNIEnv.GetStaticMethodID (class_ref, "getInteger", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getInteger_I, __args);
			} finally {
			}
		}

		static IntPtr id_getString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getString", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetString (int p0)
		{
			if (id_getString_I == IntPtr.Zero)
				id_getString_I = JNIEnv.GetStaticMethodID (class_ref, "getString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_scanXmlIdsAndNames_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='scanXmlIdsAndNames' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("scanXmlIdsAndNames", "(Ljava/lang/Class;)Ljava/util/HashMap;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, string> ScanXmlIdsAndNames (global::Java.Lang.Class p0)
		{
			if (id_scanXmlIdsAndNames_Ljava_lang_Class_ == IntPtr.Zero)
				id_scanXmlIdsAndNames_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "scanXmlIdsAndNames", "(Ljava/lang/Class;)Ljava/util/HashMap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, string> __ret = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_scanXmlIdsAndNames_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_set_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("set", "(IZ)V", "")]
		public static unsafe void Set (int p0, bool p1)
		{
			if (id_set_IZ == IntPtr.Zero)
				id_set_IZ = JNIEnv.GetStaticMethodID (class_ref, "set", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_set_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_set_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("set", "(IF)V", "")]
		public static unsafe void Set (int p0, float p1)
		{
			if (id_set_IF == IntPtr.Zero)
				id_set_IF = JNIEnv.GetStaticMethodID (class_ref, "set", "(IF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_set_IF, __args);
			} finally {
			}
		}

		static IntPtr id_set_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("set", "(II)V", "")]
		public static unsafe void Set (int p0, int p1)
		{
			if (id_set_II == IntPtr.Zero)
				id_set_II = JNIEnv.GetStaticMethodID (class_ref, "set", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_set_II, __args);
			} finally {
			}
		}

		static IntPtr id_set_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.configuration']/class[@name='Configuration']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(ILjava/lang/String;)V", "")]
		public static unsafe void Set (int p0, string p1)
		{
			if (id_set_ILjava_lang_String_ == IntPtr.Zero)
				id_set_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "set", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_set_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
