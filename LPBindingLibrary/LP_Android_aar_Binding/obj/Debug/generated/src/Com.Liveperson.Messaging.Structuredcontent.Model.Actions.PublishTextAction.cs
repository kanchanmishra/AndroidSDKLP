using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Model.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='PublishTextAction']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/actions/PublishTextAction", DoNotGenerateAcw=true)]
	public partial class PublishTextAction : global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='PublishTextAction']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/model/actions/PublishTextAction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PublishTextAction); }
		}

		protected PublishTextAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='PublishTextAction']/constructor[@name='PublishTextAction' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe PublishTextAction (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PublishTextAction)) {
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
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.PublishTextAction __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.PublishTextAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor p0 = (global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		static IntPtr id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='PublishTextAction']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.structuredcontent.visitor.ElementVisitor']]"
		[Register ("accept", "(Lcom/liveperson/messaging/structuredcontent/visitor/ElementVisitor;)V", "GetAccept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_Handler")]
		public override unsafe void Accept (global::Com.Liveperson.Messaging.Structuredcontent.Visitor.IElementVisitor p0)
		{
			if (id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ == IntPtr.Zero)
				id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_ = JNIEnv.GetMethodID (class_ref, "accept", "(Lcom/liveperson/messaging/structuredcontent/visitor/ElementVisitor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Lcom_liveperson_messaging_structuredcontent_visitor_ElementVisitor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "accept", "(Lcom/liveperson/messaging/structuredcontent/visitor/ElementVisitor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getOnClickListener_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetOnClickListener_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_getOnClickListener_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_getOnClickListener_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOnClickListener_Landroid_content_Context_Ljava_lang_String_);
			return cb_getOnClickListener_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_GetOnClickListener_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.PublishTextAction __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.PublishTextAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOnClickListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getOnClickListener_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='PublishTextAction']/method[@name='getOnClickListener' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getOnClickListener", "(Landroid/content/Context;Ljava/lang/String;)Lcom/liveperson/messaging/structuredcontent/model/actions/OnActionClickListener;", "GetGetOnClickListener_Landroid_content_Context_Ljava_lang_String_Handler")]
		public override unsafe global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener GetOnClickListener (global::Android.Content.Context p0, string p1)
		{
			if (id_getOnClickListener_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getOnClickListener_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getOnClickListener", "(Landroid/content/Context;Ljava/lang/String;)Lcom/liveperson/messaging/structuredcontent/model/actions/OnActionClickListener;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnClickListener_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnClickListener", "(Landroid/content/Context;Ljava/lang/String;)Lcom/liveperson/messaging/structuredcontent/model/actions/OnActionClickListener;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.PublishTextAction __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.PublishTextAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='PublishTextAction']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "GetToStringHandler")]
		public override unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
