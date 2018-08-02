using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Model.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='BaseAction']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/actions/BaseAction", DoNotGenerateAcw=true)]
	public abstract partial class BaseAction : global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.BaseElement {


		static IntPtr mName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='BaseAction']/field[@name='mName']"
		[Register ("mName")]
		protected string MName {
			get {
				if (mName_jfieldId == IntPtr.Zero)
					mName_jfieldId = JNIEnv.GetFieldID (class_ref, "mName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mName_jfieldId == IntPtr.Zero)
					mName_jfieldId = JNIEnv.GetFieldID (class_ref, "mName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/model/actions/BaseAction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseAction); }
		}

		protected BaseAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='BaseAction']/constructor[@name='BaseAction' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe BaseAction (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (BaseAction)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='BaseAction']/constructor[@name='BaseAction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BaseAction (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (BaseAction)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='BaseAction']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOnClickListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='BaseAction']/method[@name='getOnClickListener' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getOnClickListener", "(Landroid/content/Context;Ljava/lang/String;)Lcom/liveperson/messaging/structuredcontent/model/actions/OnActionClickListener;", "GetGetOnClickListener_Landroid_content_Context_Ljava_lang_String_Handler")]
		public abstract global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener GetOnClickListener (global::Android.Content.Context p0, string p1);

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/actions/BaseAction", DoNotGenerateAcw=true)]
	internal partial class BaseActionInvoker : BaseAction {

		public BaseActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseActionInvoker); }
		}

		static IntPtr id_getOnClickListener_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.actions']/class[@name='BaseAction']/method[@name='getOnClickListener' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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
				global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnClickListener_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
