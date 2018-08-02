using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Structuredcontent.Model.Elements {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/elements/ActionableElement", DoNotGenerateAcw=true)]
	public abstract partial class ActionableElement : global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.SimpleElement {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mActionList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/field[@name='mActionList']"
		[Register ("mActionList")]
		protected global::System.Collections.IList MActionList {
			get {
				if (mActionList_jfieldId == IntPtr.Zero)
					mActionList_jfieldId = JNIEnv.GetFieldID (class_ref, "mActionList", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mActionList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mActionList_jfieldId == IntPtr.Zero)
					mActionList_jfieldId = JNIEnv.GetFieldID (class_ref, "mActionList", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mActionList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMetadata_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/field[@name='mMetadata']"
		[Register ("mMetadata")]
		protected global::Org.Json.JSONArray MMetadata {
			get {
				if (mMetadata_jfieldId == IntPtr.Zero)
					mMetadata_jfieldId = JNIEnv.GetFieldID (class_ref, "mMetadata", "Lorg/json/JSONArray;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMetadata_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMetadata_jfieldId == IntPtr.Zero)
					mMetadata_jfieldId = JNIEnv.GetFieldID (class_ref, "mMetadata", "Lorg/json/JSONArray;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMetadata_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/structuredcontent/model/elements/ActionableElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionableElement); }
		}

		protected ActionableElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/constructor[@name='ActionableElement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ActionableElement (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ActionableElement)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/constructor[@name='ActionableElement' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe ActionableElement (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ActionableElement)) {
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

		static Delegate cb_getActions;
#pragma warning disable 0169
		static Delegate GetGetActionsHandler ()
		{
			if (cb_getActions == null)
				cb_getActions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActions);
			return cb_getActions;
		}

		static IntPtr n_GetActions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction>.ToLocalJniHandle (__this.Actions);
		}
#pragma warning restore 0169

		static IntPtr id_getActions;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction> Actions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/method[@name='getActions' and count(parameter)=0]"
			[Register ("getActions", "()Ljava/util/List;", "GetGetActionsHandler")]
			get {
				if (id_getActions == IntPtr.Zero)
					id_getActions = JNIEnv.GetMethodID (class_ref, "getActions", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getActions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Structuredcontent.Model.Actions.BaseAction>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		public virtual unsafe global::Org.Json.JSONArray Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lorg/json/JSONArray;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Lorg/json/JSONArray;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadata", "()Lorg/json/JSONArray;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_parseActions_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetParseActions_Lorg_json_JSONObject_Handler ()
		{
			if (cb_parseActions_Lorg_json_JSONObject_ == null)
				cb_parseActions_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseActions_Lorg_json_JSONObject_);
			return cb_parseActions_Lorg_json_JSONObject_;
		}

		static void n_ParseActions_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParseActions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_parseActions_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/method[@name='parseActions' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("parseActions", "(Lorg/json/JSONObject;)V", "GetParseActions_Lorg_json_JSONObject_Handler")]
		protected virtual unsafe void ParseActions (global::Org.Json.JSONObject p0)
		{
			if (id_parseActions_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_parseActions_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "parseActions", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseActions_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseActions", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_parseClick_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetParseClick_Lorg_json_JSONObject_Handler ()
		{
			if (cb_parseClick_Lorg_json_JSONObject_ == null)
				cb_parseClick_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ParseClick_Lorg_json_JSONObject_);
			return cb_parseClick_Lorg_json_JSONObject_;
		}

		static void n_ParseClick_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Structuredcontent.Model.Elements.ActionableElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParseClick (p0);
		}
#pragma warning restore 0169

		static IntPtr id_parseClick_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.structuredcontent.model.elements']/class[@name='ActionableElement']/method[@name='parseClick' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("parseClick", "(Lorg/json/JSONObject;)V", "GetParseClick_Lorg_json_JSONObject_Handler")]
		protected virtual unsafe void ParseClick (global::Org.Json.JSONObject p0)
		{
			if (id_parseClick_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_parseClick_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "parseClick", "(Lorg/json/JSONObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_parseClick_Lorg_json_JSONObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseClick", "(Lorg/json/JSONObject;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/structuredcontent/model/elements/ActionableElement", DoNotGenerateAcw=true)]
	internal partial class ActionableElementInvoker : ActionableElement {

		public ActionableElementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ActionableElementInvoker); }
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
