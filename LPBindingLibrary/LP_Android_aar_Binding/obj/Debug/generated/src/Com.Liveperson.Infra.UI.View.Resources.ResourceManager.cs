using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Resources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/resources/ResourceManager", DoNotGenerateAcw=true)]
	public sealed partial class ResourceManager : global::Java.Lang.Enum {


		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/field[@name='instance']"
		[Register ("instance")]
		public static global::Com.Liveperson.Infra.UI.View.Resources.ResourceManager Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/liveperson/infra/ui/view/resources/ResourceManager;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Resources.ResourceManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/resources/ResourceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceManager); }
		}

		internal ResourceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/method[@name='getColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColor", "(I)I", "")]
		public unsafe int GetColor (int p0)
		{
			if (id_getColor_I == IntPtr.Zero)
				id_getColor_I = JNIEnv.GetMethodID (class_ref, "getColor", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor_I, __args);
			} finally {
			}
		}

		static IntPtr id_getDimension_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/method[@name='getDimension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDimension", "(I)F", "")]
		public unsafe float GetDimension (int p0)
		{
			if (id_getDimension_I == IntPtr.Zero)
				id_getDimension_I = JNIEnv.GetMethodID (class_ref, "getDimension", "(I)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getDimension_I, __args);
			} finally {
			}
		}

		static IntPtr id_getDrawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", "")]
		public unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (int p0)
		{
			if (id_getDrawable_I == IntPtr.Zero)
				id_getDrawable_I = JNIEnv.GetMethodID (class_ref, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrawable_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_mapColor_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/method[@name='mapColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("mapColor", "(II)V", "")]
		public unsafe void MapColor (int p0, int p1)
		{
			if (id_mapColor_II == IntPtr.Zero)
				id_mapColor_II = JNIEnv.GetMethodID (class_ref, "mapColor", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mapColor_II, __args);
			} finally {
			}
		}

		static IntPtr id_mapDimension_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/method[@name='mapDimension' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("mapDimension", "(IF)V", "")]
		public unsafe void MapDimension (int p0, float p1)
		{
			if (id_mapDimension_IF == IntPtr.Zero)
				id_mapDimension_IF = JNIEnv.GetMethodID (class_ref, "mapDimension", "(IF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mapDimension_IF, __args);
			} finally {
			}
		}

		static IntPtr id_mapDrawable_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/method[@name='mapDrawable' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("mapDrawable", "(II)V", "")]
		public unsafe void MapDrawable (int p0, int p1)
		{
			if (id_mapDrawable_II == IntPtr.Zero)
				id_mapDrawable_II = JNIEnv.GetMethodID (class_ref, "mapDrawable", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_mapDrawable_II, __args);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/ui/view/resources/ResourceManager;", "")]
		public static unsafe global::Com.Liveperson.Infra.UI.View.Resources.ResourceManager ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/ui/view/resources/ResourceManager;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Liveperson.Infra.UI.View.Resources.ResourceManager __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Resources.ResourceManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.resources']/class[@name='ResourceManager']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/liveperson/infra/ui/view/resources/ResourceManager;", "")]
		public static unsafe global::Com.Liveperson.Infra.UI.View.Resources.ResourceManager[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/ui/view/resources/ResourceManager;");
			try {
				return (global::Com.Liveperson.Infra.UI.View.Resources.ResourceManager[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.UI.View.Resources.ResourceManager));
			} finally {
			}
		}

	}
}
