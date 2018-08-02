using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/Form", DoNotGenerateAcw=true)]
	public partial class Form : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/model/Form$FormStatus", DoNotGenerateAcw=true)]
		public sealed partial class FormStatus : global::Java.Lang.Enum {


			static IntPtr ABORTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/field[@name='ABORTED']"
			[Register ("ABORTED")]
			public static global::Com.Liveperson.Messaging.Model.Form.FormStatus Aborted {
				get {
					if (ABORTED_jfieldId == IntPtr.Zero)
						ABORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ABORTED", "Lcom/liveperson/messaging/model/Form$FormStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ABORTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Com.Liveperson.Messaging.Model.Form.FormStatus Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/liveperson/messaging/model/Form$FormStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Liveperson.Messaging.Model.Form.FormStatus Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/liveperson/messaging/model/Form$FormStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EXPIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/field[@name='EXPIRED']"
			[Register ("EXPIRED")]
			public static global::Com.Liveperson.Messaging.Model.Form.FormStatus Expired {
				get {
					if (EXPIRED_jfieldId == IntPtr.Zero)
						EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRED", "Lcom/liveperson/messaging/model/Form$FormStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr READY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/field[@name='READY']"
			[Register ("READY")]
			public static global::Com.Liveperson.Messaging.Model.Form.FormStatus Ready {
				get {
					if (READY_jfieldId == IntPtr.Zero)
						READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READY", "Lcom/liveperson/messaging/model/Form$FormStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SUBMITTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/field[@name='SUBMITTED']"
			[Register ("SUBMITTED")]
			public static global::Com.Liveperson.Messaging.Model.Form.FormStatus Submitted {
				get {
					if (SUBMITTED_jfieldId == IntPtr.Zero)
						SUBMITTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUBMITTED", "Lcom/liveperson/messaging/model/Form$FormStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUBMITTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIEWED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/field[@name='VIEWED']"
			[Register ("VIEWED")]
			public static global::Com.Liveperson.Messaging.Model.Form.FormStatus Viewed {
				get {
					if (VIEWED_jfieldId == IntPtr.Zero)
						VIEWED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIEWED", "Lcom/liveperson/messaging/model/Form$FormStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIEWED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/model/Form$FormStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FormStatus); }
			}

			internal FormStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Form$FormStatus;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.Form.FormStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/Form$FormStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Messaging.Model.Form.FormStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form.FormStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/messaging/model/Form$FormStatus;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.Form.FormStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/model/Form$FormStatus;");
				try {
					return (global::Com.Liveperson.Messaging.Model.Form.FormStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Model.Form.FormStatus));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/Form", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Form); }
		}

		protected Form (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/constructor[@name='Form' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe Form (string p0, string p1, string p2, string p3, string p4, string p5, int p6, string p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (native_p7);
				if (((object) this).GetType () != typeof (Form)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/constructor[@name='Form' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Form (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (native_p7);
				__args [8] = new JValue (native_p8);
				if (((object) this).GetType () != typeof (Form)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
				JNIEnv.DeleteLocalRef (native_p7);
				JNIEnv.DeleteLocalRef (native_p8);
			}
		}

		static Delegate cb_getConversationId;
#pragma warning disable 0169
		static Delegate GetGetConversationIdHandler ()
		{
			if (cb_getConversationId == null)
				cb_getConversationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationId);
			return cb_getConversationId;
		}

		static IntPtr n_GetConversationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationId);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationId;
		public virtual unsafe string ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getConversationId' and count(parameter)=0]"
			[Register ("getConversationId", "()Ljava/lang/String;", "GetGetConversationIdHandler")]
			get {
				if (id_getConversationId == IntPtr.Zero)
					id_getConversationId = JNIEnv.GetMethodID (class_ref, "getConversationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventId);
			return cb_getEventId;
		}

		static IntPtr n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventId);
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		public virtual unsafe string EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()Ljava/lang/String;", "GetGetEventIdHandler")]
			get {
				if (id_getEventId == IntPtr.Zero)
					id_getEventId = JNIEnv.GetMethodID (class_ref, "getEventId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormId;
#pragma warning disable 0169
		static Delegate GetGetFormIdHandler ()
		{
			if (cb_getFormId == null)
				cb_getFormId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormId);
			return cb_getFormId;
		}

		static IntPtr n_GetFormId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormId);
		}
#pragma warning restore 0169

		static IntPtr id_getFormId;
		public virtual unsafe string FormId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getFormId' and count(parameter)=0]"
			[Register ("getFormId", "()Ljava/lang/String;", "GetGetFormIdHandler")]
			get {
				if (id_getFormId == IntPtr.Zero)
					id_getFormId = JNIEnv.GetMethodID (class_ref, "getFormId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormTitle;
#pragma warning disable 0169
		static Delegate GetGetFormTitleHandler ()
		{
			if (cb_getFormTitle == null)
				cb_getFormTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormTitle);
			return cb_getFormTitle;
		}

		static IntPtr n_GetFormTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormTitle);
		}
#pragma warning restore 0169

		static IntPtr id_getFormTitle;
		public virtual unsafe string FormTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getFormTitle' and count(parameter)=0]"
			[Register ("getFormTitle", "()Ljava/lang/String;", "GetGetFormTitleHandler")]
			get {
				if (id_getFormTitle == IntPtr.Zero)
					id_getFormTitle = JNIEnv.GetMethodID (class_ref, "getFormTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInvitationId;
#pragma warning disable 0169
		static Delegate GetGetInvitationIdHandler ()
		{
			if (cb_getInvitationId == null)
				cb_getInvitationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInvitationId);
			return cb_getInvitationId;
		}

		static IntPtr n_GetInvitationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.InvitationId);
		}
#pragma warning restore 0169

		static IntPtr id_getInvitationId;
		public virtual unsafe string InvitationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getInvitationId' and count(parameter)=0]"
			[Register ("getInvitationId", "()Ljava/lang/String;", "GetGetInvitationIdHandler")]
			get {
				if (id_getInvitationId == IntPtr.Zero)
					id_getInvitationId = JNIEnv.GetMethodID (class_ref, "getInvitationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInvitationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInvitationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static IntPtr id_getLanguage;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLanguage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOpenFormURL;
#pragma warning disable 0169
		static Delegate GetGetOpenFormURLHandler ()
		{
			if (cb_getOpenFormURL == null)
				cb_getOpenFormURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpenFormURL);
			return cb_getOpenFormURL;
		}

		static IntPtr n_GetOpenFormURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OpenFormURL);
		}
#pragma warning restore 0169

		static IntPtr id_getOpenFormURL;
		public virtual unsafe string OpenFormURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getOpenFormURL' and count(parameter)=0]"
			[Register ("getOpenFormURL", "()Ljava/lang/String;", "GetGetOpenFormURLHandler")]
			get {
				if (id_getOpenFormURL == IntPtr.Zero)
					id_getOpenFormURL = JNIEnv.GetMethodID (class_ref, "getOpenFormURL", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOpenFormURL), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpenFormURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReadOTK;
#pragma warning disable 0169
		static Delegate GetGetReadOTKHandler ()
		{
			if (cb_getReadOTK == null)
				cb_getReadOTK = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReadOTK);
			return cb_getReadOTK;
		}

		static IntPtr n_GetReadOTK (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReadOTK);
		}
#pragma warning restore 0169

		static Delegate cb_setReadOTK_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReadOTK_Ljava_lang_String_Handler ()
		{
			if (cb_setReadOTK_Ljava_lang_String_ == null)
				cb_setReadOTK_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReadOTK_Ljava_lang_String_);
			return cb_setReadOTK_Ljava_lang_String_;
		}

		static void n_SetReadOTK_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadOTK = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReadOTK;
		static IntPtr id_setReadOTK_Ljava_lang_String_;
		public virtual unsafe string ReadOTK {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getReadOTK' and count(parameter)=0]"
			[Register ("getReadOTK", "()Ljava/lang/String;", "GetGetReadOTKHandler")]
			get {
				if (id_getReadOTK == IntPtr.Zero)
					id_getReadOTK = JNIEnv.GetMethodID (class_ref, "getReadOTK", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReadOTK), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReadOTK", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='setReadOTK' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReadOTK", "(Ljava/lang/String;)V", "GetSetReadOTK_Ljava_lang_String_Handler")]
			set {
				if (id_setReadOTK_Ljava_lang_String_ == IntPtr.Zero)
					id_setReadOTK_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReadOTK", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReadOTK_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadOTK", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSeqId;
#pragma warning disable 0169
		static Delegate GetGetSeqIdHandler ()
		{
			if (cb_getSeqId == null)
				cb_getSeqId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeqId);
			return cb_getSeqId;
		}

		static int n_GetSeqId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeqId;
		}
#pragma warning restore 0169

		static IntPtr id_getSeqId;
		public virtual unsafe int SeqId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getSeqId' and count(parameter)=0]"
			[Register ("getSeqId", "()I", "GetGetSeqIdHandler")]
			get {
				if (id_getSeqId == IntPtr.Zero)
					id_getSeqId = JNIEnv.GetMethodID (class_ref, "getSeqId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSeqId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeqId", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSiteId;
#pragma warning disable 0169
		static Delegate GetGetSiteIdHandler ()
		{
			if (cb_getSiteId == null)
				cb_getSiteId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteId);
			return cb_getSiteId;
		}

		static IntPtr n_GetSiteId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteId);
		}
#pragma warning restore 0169

		static IntPtr id_getSiteId;
		public virtual unsafe string SiteId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getSiteId' and count(parameter)=0]"
			[Register ("getSiteId", "()Ljava/lang/String;", "GetGetSiteIdHandler")]
			get {
				if (id_getSiteId == IntPtr.Zero)
					id_getSiteId = JNIEnv.GetMethodID (class_ref, "getSiteId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubmissionId;
#pragma warning disable 0169
		static Delegate GetGetSubmissionIdHandler ()
		{
			if (cb_getSubmissionId == null)
				cb_getSubmissionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubmissionId);
			return cb_getSubmissionId;
		}

		static IntPtr n_GetSubmissionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubmissionId);
		}
#pragma warning restore 0169

		static Delegate cb_setSubmissionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubmissionId_Ljava_lang_String_Handler ()
		{
			if (cb_setSubmissionId_Ljava_lang_String_ == null)
				cb_setSubmissionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubmissionId_Ljava_lang_String_);
			return cb_setSubmissionId_Ljava_lang_String_;
		}

		static void n_SetSubmissionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubmissionId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSubmissionId;
		static IntPtr id_setSubmissionId_Ljava_lang_String_;
		public virtual unsafe string SubmissionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getSubmissionId' and count(parameter)=0]"
			[Register ("getSubmissionId", "()Ljava/lang/String;", "GetGetSubmissionIdHandler")]
			get {
				if (id_getSubmissionId == IntPtr.Zero)
					id_getSubmissionId = JNIEnv.GetMethodID (class_ref, "getSubmissionId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSubmissionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubmissionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='setSubmissionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubmissionId", "(Ljava/lang/String;)V", "GetSetSubmissionId_Ljava_lang_String_Handler")]
			set {
				if (id_setSubmissionId_Ljava_lang_String_ == IntPtr.Zero)
					id_setSubmissionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSubmissionId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSubmissionId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubmissionId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWriteOTK;
#pragma warning disable 0169
		static Delegate GetGetWriteOTKHandler ()
		{
			if (cb_getWriteOTK == null)
				cb_getWriteOTK = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWriteOTK);
			return cb_getWriteOTK;
		}

		static IntPtr n_GetWriteOTK (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WriteOTK);
		}
#pragma warning restore 0169

		static Delegate cb_setWriteOTK_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWriteOTK_Ljava_lang_String_Handler ()
		{
			if (cb_setWriteOTK_Ljava_lang_String_ == null)
				cb_setWriteOTK_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWriteOTK_Ljava_lang_String_);
			return cb_setWriteOTK_Ljava_lang_String_;
		}

		static void n_SetWriteOTK_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteOTK = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteOTK;
		static IntPtr id_setWriteOTK_Ljava_lang_String_;
		public virtual unsafe string WriteOTK {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getWriteOTK' and count(parameter)=0]"
			[Register ("getWriteOTK", "()Ljava/lang/String;", "GetGetWriteOTKHandler")]
			get {
				if (id_getWriteOTK == IntPtr.Zero)
					id_getWriteOTK = JNIEnv.GetMethodID (class_ref, "getWriteOTK", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWriteOTK), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWriteOTK", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='setWriteOTK' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setWriteOTK", "(Ljava/lang/String;)V", "GetSetWriteOTK_Ljava_lang_String_Handler")]
			set {
				if (id_setWriteOTK_Ljava_lang_String_ == IntPtr.Zero)
					id_setWriteOTK_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWriteOTK", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWriteOTK_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWriteOTK", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFormStatus;
#pragma warning disable 0169
		static Delegate GetGetFormStatusHandler ()
		{
			if (cb_getFormStatus == null)
				cb_getFormStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormStatus);
			return cb_getFormStatus;
		}

		static IntPtr n_GetFormStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFormStatus ());
		}
#pragma warning restore 0169

		static IntPtr id_getFormStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='getFormStatus' and count(parameter)=0]"
		[Register ("getFormStatus", "()Lcom/liveperson/messaging/model/Form$FormStatus;", "GetGetFormStatusHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.Form.FormStatus GetFormStatus ()
		{
			if (id_getFormStatus == IntPtr.Zero)
				id_getFormStatus = JNIEnv.GetMethodID (class_ref, "getFormStatus", "()Lcom/liveperson/messaging/model/Form$FormStatus;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormStatus), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormStatus", "()Lcom/liveperson/messaging/model/Form$FormStatus;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_;
#pragma warning disable 0169
		static Delegate GetSetFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_Handler ()
		{
			if (cb_setFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_ == null)
				cb_setFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_);
			return cb_setFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_;
		}

		static void n_SetFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.Form __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.Form.FormStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form.FormStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFormStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='Form']/method[@name='setFormStatus' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.Form.FormStatus']]"
		[Register ("setFormStatus", "(Lcom/liveperson/messaging/model/Form$FormStatus;)V", "GetSetFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_Handler")]
		public virtual unsafe void SetFormStatus (global::Com.Liveperson.Messaging.Model.Form.FormStatus p0)
		{
			if (id_setFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_ == IntPtr.Zero)
				id_setFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_ = JNIEnv.GetMethodID (class_ref, "setFormStatus", "(Lcom/liveperson/messaging/model/Form$FormStatus;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFormStatus_Lcom_liveperson_messaging_model_Form_FormStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFormStatus", "(Lcom/liveperson/messaging/model/Form$FormStatus;)V"), __args);
			} finally {
			}
		}

	}
}
