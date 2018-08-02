using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Visitor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']"
	[Register ("com/liveperson/messaging/structuredcontent/visitor/ElementVisitor", "", "Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker")]
	public partial interface IElementVisitor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ButtonElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ButtonElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.ImageElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ImageElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.LinkElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/LinkElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.MapElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/MapElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.TextElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/TextElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.basic.WebViewElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/WebViewElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.CarouselElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/CarouselElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.LayoutElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/LayoutElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='ElementVisitor']/method[@name='visit' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.model.elements.complex.QuickRepliesElement']]"
		[Register ("visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;)V", "GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitorInvoker, LP_Android_aar_Binding")]
		void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/visitor/ElementVisitor", DoNotGenerateAcw=true)]
	internal class IElementVisitorInvoker : global::Java.Lang.Object, IElementVisitor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/visitor/ElementVisitor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IElementVisitorInvoker); }
		}

		IntPtr class_ref;

		public static IElementVisitor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IElementVisitor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.structuredcontent.visitor.ElementVisitor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IElementVisitorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ButtonElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ButtonElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ButtonElement_, __args);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.ImageElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/ImageElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_ImageElement_, __args);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.LinkElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/LinkElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_LinkElement_, __args);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.MapElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/MapElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_MapElement_, __args);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.TextElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/TextElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_TextElement_, __args);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Basic.WebViewElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/basic/WebViewElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_basic_WebViewElement_, __args);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.CarouselElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/CarouselElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_CarouselElement_, __args);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.LayoutElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/LayoutElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_LayoutElement_, __args);
		}

		static Delegate cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_;
#pragma warning disable 0169
		static Delegate GetVisit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_Handler ()
		{
			if (cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ == null)
				cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_);
			return cb_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_;
		}

		static void n_Visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Visit (p0);
		}
#pragma warning restore 0169

		IntPtr id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_;
		public unsafe void Visit (global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.Complex.QuickRepliesElement p0)
		{
			if (id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ == IntPtr.Zero)
				id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_ = JNIEnv.GetMethodID (class_ref, "visit", "(Lcom/liveperson/messaging/structuredcontent/model/elements/complex/QuickRepliesElement;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_visit_Lcom_liveperson_messaging_structuredcontent_model_elements_complex_QuickRepliesElement_, __args);
		}

	}

}
