using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle", DoNotGenerateAcw=true)]
	public partial class ElementStyle : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle.ElementSize']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize", DoNotGenerateAcw=true)]
		public sealed partial class ElementSize : global::Java.Lang.Enum {


			static IntPtr large_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle.ElementSize']/field[@name='large']"
			[Register ("large")]
			public static global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize Large {
				get {
					if (large_jfieldId == IntPtr.Zero)
						large_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "large", "Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, large_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr medium_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle.ElementSize']/field[@name='medium']"
			[Register ("medium")]
			public static global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize Medium {
				get {
					if (medium_jfieldId == IntPtr.Zero)
						medium_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "medium", "Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, medium_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr small_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle.ElementSize']/field[@name='small']"
			[Register ("small")]
			public static global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize Small {
				get {
					if (small_jfieldId == IntPtr.Zero)
						small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "small", "Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, small_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ElementSize); }
			}

			internal ElementSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle.ElementSize']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle.ElementSize']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;");
				try {
					return (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ElementStyle); }
		}

		protected ElementStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/constructor[@name='ElementStyle' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ElementStyle (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ElementStyle)) {
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

		static Delegate cb_getBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_getBackgroundColor == null)
				cb_getBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBackgroundColor);
			return cb_getBackgroundColor;
		}

		static int n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColor;
		}
#pragma warning restore 0169

		static IntPtr id_getBackgroundColor;
		public virtual unsafe int BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get {
				if (id_getBackgroundColor == IntPtr.Zero)
					id_getBackgroundColor = JNIEnv.GetMethodID (class_ref, "getBackgroundColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBackgroundColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBackgroundColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBorderColorHandler ()
		{
			if (cb_getBorderColor == null)
				cb_getBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBorderColor);
			return cb_getBorderColor;
		}

		static IntPtr n_GetBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BorderColor);
		}
#pragma warning restore 0169

		static IntPtr id_getBorderColor;
		public virtual unsafe global::Java.Lang.Integer BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()Ljava/lang/Integer;", "GetGetBorderColorHandler")]
			get {
				if (id_getBorderColor == IntPtr.Zero)
					id_getBorderColor = JNIEnv.GetMethodID (class_ref, "getBorderColor", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBorderColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderColor", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBorderRadius;
#pragma warning disable 0169
		static Delegate GetGetBorderRadiusHandler ()
		{
			if (cb_getBorderRadius == null)
				cb_getBorderRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBorderRadius);
			return cb_getBorderRadius;
		}

		static IntPtr n_GetBorderRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BorderRadius);
		}
#pragma warning restore 0169

		static IntPtr id_getBorderRadius;
		public virtual unsafe global::Java.Lang.Integer BorderRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/method[@name='getBorderRadius' and count(parameter)=0]"
			[Register ("getBorderRadius", "()Ljava/lang/Integer;", "GetGetBorderRadiusHandler")]
			get {
				if (id_getBorderRadius == IntPtr.Zero)
					id_getBorderRadius = JNIEnv.GetMethodID (class_ref, "getBorderRadius", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBorderRadius), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBorderRadius", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isBold;
#pragma warning disable 0169
		static Delegate GetIsBoldHandler ()
		{
			if (cb_isBold == null)
				cb_isBold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBold);
			return cb_isBold;
		}

		static bool n_IsBold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBold;
		}
#pragma warning restore 0169

		static IntPtr id_isBold;
		public virtual unsafe bool IsBold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/method[@name='isBold' and count(parameter)=0]"
			[Register ("isBold", "()Z", "GetIsBoldHandler")]
			get {
				if (id_isBold == IntPtr.Zero)
					id_isBold = JNIEnv.GetMethodID (class_ref, "isBold", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBold);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBold", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isItalic;
#pragma warning disable 0169
		static Delegate GetIsItalicHandler ()
		{
			if (cb_isItalic == null)
				cb_isItalic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsItalic);
			return cb_isItalic;
		}

		static bool n_IsItalic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsItalic;
		}
#pragma warning restore 0169

		static IntPtr id_isItalic;
		public virtual unsafe bool IsItalic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/method[@name='isItalic' and count(parameter)=0]"
			[Register ("isItalic", "()Z", "GetIsItalicHandler")]
			get {
				if (id_isItalic == IntPtr.Zero)
					id_isItalic = JNIEnv.GetMethodID (class_ref, "isItalic", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isItalic);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isItalic", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSize);
			return cb_getSize;
		}

		static IntPtr n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size);
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual unsafe global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSize), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle.ElementSize> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ElementStyle$ElementSize;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextColor);
			return cb_getTextColor;
		}

		static IntPtr n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getTextColor;
		public virtual unsafe global::Java.Lang.Integer TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()Ljava/lang/Integer;", "GetGetTextColorHandler")]
			get {
				if (id_getTextColor == IntPtr.Zero)
					id_getTextColor = JNIEnv.GetMethodID (class_ref, "getTextColor", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextColor", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setDefaultValues;
#pragma warning disable 0169
		static Delegate GetSetDefaultValuesHandler ()
		{
			if (cb_setDefaultValues == null)
				cb_setDefaultValues = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetDefaultValues);
			return cb_setDefaultValues;
		}

		static void n_SetDefaultValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ElementStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultValues ();
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.basic']/class[@name='ElementStyle']/method[@name='setDefaultValues' and count(parameter)=0]"
		[Register ("setDefaultValues", "()V", "GetSetDefaultValuesHandler")]
		protected virtual unsafe void SetDefaultValues ()
		{
			if (id_setDefaultValues == IntPtr.Zero)
				id_setDefaultValues = JNIEnv.GetMethodID (class_ref, "setDefaultValues", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultValues);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultValues", "()V"));
			} finally {
			}
		}

	}
}
