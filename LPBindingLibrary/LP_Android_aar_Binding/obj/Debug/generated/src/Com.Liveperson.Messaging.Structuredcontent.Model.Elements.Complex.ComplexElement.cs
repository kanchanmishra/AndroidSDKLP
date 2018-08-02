using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.complex']/class[@name='ComplexElement']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/elements/complex/ComplexElement", DoNotGenerateAcw=true)]
	public abstract partial class ComplexElement : global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement {


		static IntPtr mElementList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.complex']/class[@name='ComplexElement']/field[@name='mElementList']"
		[Register ("mElementList")]
		protected global::System.Collections.IList MElementList {
			get {
				if (mElementList_jfieldId == IntPtr.Zero)
					mElementList_jfieldId = JNIEnv.GetFieldID (class_ref, "mElementList", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mElementList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mElementList_jfieldId == IntPtr.Zero)
					mElementList_jfieldId = JNIEnv.GetFieldID (class_ref, "mElementList", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mElementList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/model/elements/complex/ComplexElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ComplexElement); }
		}

		protected ComplexElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.complex']/class[@name='ComplexElement']/constructor[@name='ComplexElement' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ComplexElement (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ComplexElement)) {
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

		static IntPtr id_ctor_Lorg_json_JSONObject_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.complex']/class[@name='ComplexElement']/constructor[@name='ComplexElement' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/json/JSONObject;Ljava/lang/String;)V", "")]
		public unsafe ComplexElement (global::Org.Json.JSONObject p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ComplexElement)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONObject;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.complex']/class[@name='ComplexElement']/constructor[@name='ComplexElement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ComplexElement (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ComplexElement)) {
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

		static Delegate cb_getElementList;
#pragma warning disable 0169
		static Delegate GetGetElementListHandler ()
		{
			if (cb_getElementList == null)
				cb_getElementList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetElementList);
			return cb_getElementList;
		}

		static IntPtr n_GetElementList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.ComplexElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.ComplexElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.BaseElement>.ToLocalJniHandle (__this.ElementList);
		}
#pragma warning restore 0169

		static IntPtr id_getElementList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.BaseElement> ElementList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.complex']/class[@name='ComplexElement']/method[@name='getElementList' and count(parameter)=0]"
			[Register ("getElementList", "()Ljava/util/List;", "GetGetElementListHandler")]
			get {
				if (id_getElementList == IntPtr.Zero)
					id_getElementList = JNIEnv.GetMethodID (class_ref, "getElementList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.BaseElement>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElementList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.BaseElement>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getElementList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_;
#pragma warning disable 0169
		static Delegate GetAddElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Handler ()
		{
			if (cb_addElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ == null)
				cb_addElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_);
			return cb_addElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_;
		}

		static void n_AddElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.ComplexElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.ComplexElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddElement (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements.complex']/class[@name='ComplexElement']/method[@name='addElement' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.SimpleElement']]"
		[Register ("addElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;)V", "GetAddElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_Handler")]
		public virtual unsafe void AddElement (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement p0)
		{
			if (id_addElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ == IntPtr.Zero)
				id_addElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_ = JNIEnv.GetMethodID (class_ref, "addElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addElement_Lcom_liveperson_messaging_structuredcontent_model_elements_SimpleElement_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addElement", "(Lcom/liveperson/messaging/structuredcontent/model/elements/SimpleElement;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/elements/complex/ComplexElement", DoNotGenerateAcw=true)]
	internal partial class ComplexElementInvoker : ComplexElement {

		public ComplexElementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ComplexElementInvoker); }
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
