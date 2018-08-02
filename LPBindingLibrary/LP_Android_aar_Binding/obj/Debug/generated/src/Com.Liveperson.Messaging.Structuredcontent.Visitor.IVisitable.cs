using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Visitor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='Visitable']"
	[Register ("com/liveperson/messaging/structuredcontent/visitor/Visitable", "", "Com.Liveperson.Messaging.Structuredcontent.Visitor.IVisitableInvoker")]
	public partial interface IVisitable : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.visitor']/interface[@name='Visitable']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.visitor.ElementVisitor']]"
		[Register ("accept", "(Lcom/liveperson/messaging/structuredcontent/visitor/ElementVisitor;)V", "GetAccept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_Handler:Com.Liveperson.Messaging.Structuredcontent.Visitor.IVisitableInvoker, LP_Android_aar_Binding")]
		void Accept (global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/visitor/Visitable", DoNotGenerateAcw=true)]
	internal class IVisitableInvoker : global::Java.Lang.Object, IVisitable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/visitor/Visitable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVisitableInvoker); }
		}

		IntPtr class_ref;

		public static IVisitable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVisitable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.structuredcontent.visitor.Visitable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVisitableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_;
#pragma warning disable 0169
		static Delegate GetAccept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_Handler ()
		{
			if (cb_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ == null)
				cb_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_);
			return cb_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_;
		}

		static void n_Accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IVisitable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IVisitable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor p0 = (global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_;
		public unsafe void Accept (global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor p0)
		{
			if (id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ == IntPtr.Zero)
				id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ = JNIEnv.GetMethodID (class_ref, "accept", "(Lcom/liveperson/messaging/structuredcontent/visitor/ElementVisitor;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_, __args);
		}

	}

}
