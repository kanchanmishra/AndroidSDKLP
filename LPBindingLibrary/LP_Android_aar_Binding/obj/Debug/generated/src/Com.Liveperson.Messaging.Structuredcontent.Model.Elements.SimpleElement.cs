using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Model.Elements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/elements/SimpleElement", DoNotGenerateAcw=true)]
	public abstract partial class SimpleElement : global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.BaseElement {


		static IntPtr mRtl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']/field[@name='mRtl']"
		[Register ("mRtl")]
		protected bool MRtl {
			get {
				if (mRtl_jfieldId == IntPtr.Zero)
					mRtl_jfieldId = JNIEnv.GetFieldID (class_ref, "mRtl", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mRtl_jfieldId);
			}
			set {
				if (mRtl_jfieldId == IntPtr.Zero)
					mRtl_jfieldId = JNIEnv.GetFieldID (class_ref, "mRtl", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRtl_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mTooltip_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']/field[@name='mTooltip']"
		[Register ("mTooltip")]
		protected string MTooltip {
			get {
				if (mTooltip_jfieldId == IntPtr.Zero)
					mTooltip_jfieldId = JNIEnv.GetFieldID (class_ref, "mTooltip", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTooltip_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTooltip_jfieldId == IntPtr.Zero)
					mTooltip_jfieldId = JNIEnv.GetFieldID (class_ref, "mTooltip", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTooltip_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/model/elements/SimpleElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleElement); }
		}

		protected SimpleElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']/constructor[@name='SimpleElement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SimpleElement (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (SimpleElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']/constructor[@name='SimpleElement' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe SimpleElement (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SimpleElement)) {
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

		static Delegate cb_isRtl;
#pragma warning disable 0169
		static Delegate GetIsRtlHandler ()
		{
			if (cb_isRtl == null)
				cb_isRtl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRtl);
			return cb_isRtl;
		}

		static bool n_IsRtl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rtl;
		}
#pragma warning restore 0169

		static Delegate cb_setRtl_Z;
#pragma warning disable 0169
		static Delegate GetSetRtl_ZHandler ()
		{
			if (cb_setRtl_Z == null)
				cb_setRtl_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRtl_Z);
			return cb_setRtl_Z;
		}

		static void n_SetRtl_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rtl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isRtl;
		static IntPtr id_setRtl_Z;
		public virtual unsafe bool Rtl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']/method[@name='isRtl' and count(parameter)=0]"
			[Register ("isRtl", "()Z", "GetIsRtlHandler")]
			get {
				if (id_isRtl == IntPtr.Zero)
					id_isRtl = JNIEnv.GetMethodID (class_ref, "isRtl", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRtl);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRtl", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']/method[@name='setRtl' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRtl", "(Z)V", "GetSetRtl_ZHandler")]
			set {
				if (id_setRtl_Z == IntPtr.Zero)
					id_setRtl_Z = JNIEnv.GetMethodID (class_ref, "setRtl", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRtl_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRtl", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTooltip;
#pragma warning disable 0169
		static Delegate GetGetTooltipHandler ()
		{
			if (cb_getTooltip == null)
				cb_getTooltip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTooltip);
			return cb_getTooltip;
		}

		static IntPtr n_GetTooltip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tooltip);
		}
#pragma warning restore 0169

		static Delegate cb_setTooltip_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTooltip_Ljava_lang_String_Handler ()
		{
			if (cb_setTooltip_Ljava_lang_String_ == null)
				cb_setTooltip_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTooltip_Ljava_lang_String_);
			return cb_setTooltip_Ljava_lang_String_;
		}

		static void n_SetTooltip_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tooltip = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTooltip;
		static IntPtr id_setTooltip_Ljava_lang_String_;
		public virtual unsafe string Tooltip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']/method[@name='getTooltip' and count(parameter)=0]"
			[Register ("getTooltip", "()Ljava/lang/String;", "GetGetTooltipHandler")]
			get {
				if (id_getTooltip == IntPtr.Zero)
					id_getTooltip = JNIEnv.GetMethodID (class_ref, "getTooltip", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTooltip), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTooltip", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='SimpleElement']/method[@name='setTooltip' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTooltip", "(Ljava/lang/String;)V", "GetSetTooltip_Ljava_lang_String_Handler")]
			set {
				if (id_setTooltip_Ljava_lang_String_ == IntPtr.Zero)
					id_setTooltip_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTooltip", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTooltip_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTooltip", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/elements/SimpleElement", DoNotGenerateAcw=true)]
	internal partial class SimpleElementInvoker : SimpleElement {

		public SimpleElementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleElementInvoker); }
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='BaseElement']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='Visitable']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.visitor.ElementVisitor']]"
		[Register ("accept", "(Lcom/liveperson/messaging/structuredcontent/visitor/ElementVisitor;)V", "GetAccept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_Handler")]
		public override unsafe void Accept (global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor p0)
		{
			if (id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ == IntPtr.Zero)
				id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ = JNIEnv.GetMethodID (class_ref, "accept", "(Lcom/liveperson/messaging/structuredcontent/visitor/ElementVisitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_, __args);
			} finally {
			}
		}

	}

}
