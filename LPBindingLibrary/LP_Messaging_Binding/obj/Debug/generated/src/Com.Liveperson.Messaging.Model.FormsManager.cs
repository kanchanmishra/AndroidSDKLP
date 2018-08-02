using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/FormsManager", DoNotGenerateAcw=true)]
	public partial class FormsManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/field[@name='FORM_ID']"
		[Register ("FORM_ID")]
		public const string FormId = (string) "formId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/field[@name='INVITATION_ID']"
		[Register ("INVITATION_ID")]
		public const string InvitationId = (string) "invitationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/field[@name='TITLE']"
		[Register ("TITLE")]
		public const string Title = (string) "title";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/FormsManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FormsManager); }
		}

		protected FormsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/constructor[@name='FormsManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FormsManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FormsManager)) {
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

		static Delegate cb_addForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_;
#pragma warning disable 0169
		static Delegate GetAddForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_Handler ()
		{
			if (cb_addForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_ == null)
				cb_addForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_);
			return cb_addForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_;
		}

		static void n_AddForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.FormsManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FormsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.Form p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddForm (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/method[@name='addForm' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.model.Form']]"
		[Register ("addForm", "(Ljava/lang/String;Lcom/liveperson/messaging/model/Form;)V", "GetAddForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_Handler")]
		public virtual unsafe void AddForm (string p0, global::Com.Liveperson.Messaging.Model.Form p1)
		{
			if (id_addForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_ == IntPtr.Zero)
				id_addForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_ = JNIEnv.GetMethodID (class_ref, "addForm", "(Ljava/lang/String;Lcom/liveperson/messaging/model/Form;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addForm_Ljava_lang_String_Lcom_liveperson_messaging_model_Form_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addForm", "(Ljava/lang/String;Lcom/liveperson/messaging/model/Form;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getForm_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetForm_Ljava_lang_String_Handler ()
		{
			if (cb_getForm_Ljava_lang_String_ == null)
				cb_getForm_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetForm_Ljava_lang_String_);
			return cb_getForm_Ljava_lang_String_;
		}

		static IntPtr n_GetForm_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.FormsManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FormsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetForm (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getForm_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/method[@name='getForm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getForm", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Form;", "GetGetForm_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.Form GetForm (string p0)
		{
			if (id_getForm_Ljava_lang_String_ == IntPtr.Zero)
				id_getForm_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getForm", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Form;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.Form __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getForm_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getForm", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Form;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeForm_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveForm_Ljava_lang_String_Handler ()
		{
			if (cb_removeForm_Ljava_lang_String_ == null)
				cb_removeForm_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveForm_Ljava_lang_String_);
			return cb_removeForm_Ljava_lang_String_;
		}

		static void n_RemoveForm_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.FormsManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FormsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveForm (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeForm_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/method[@name='removeForm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeForm", "(Ljava/lang/String;)V", "GetRemoveForm_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveForm (string p0)
		{
			if (id_removeForm_Ljava_lang_String_ == IntPtr.Zero)
				id_removeForm_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeForm", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeForm_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeForm", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateForm_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateForm_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateForm_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateForm_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateForm_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateForm_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateForm_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.FormsManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FormsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateForm (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateForm_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/method[@name='updateForm' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateForm", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateForm_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateForm (string p0, string p1)
		{
			if (id_updateForm_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateForm_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateForm", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateForm_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateForm", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Model.FormsManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FormsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateForm (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='FormsManager']/method[@name='updateForm' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("updateForm", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateForm (string p0, string p1, string p2)
		{
			if (id_updateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateForm", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateForm_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateForm", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
