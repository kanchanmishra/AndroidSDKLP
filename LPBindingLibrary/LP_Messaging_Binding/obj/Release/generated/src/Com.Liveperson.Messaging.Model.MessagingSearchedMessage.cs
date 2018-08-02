using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/MessagingSearchedMessage", DoNotGenerateAcw=true)]
	public partial class MessagingSearchedMessage : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/MessagingSearchedMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagingSearchedMessage); }
		}

		protected MessagingSearchedMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/constructor[@name='MessagingSearchedMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessagingSearchedMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessagingSearchedMessage)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/constructor[@name='MessagingSearchedMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", "")]
		public unsafe MessagingSearchedMessage (string p0, string p1, string p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (MessagingSearchedMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getBrandId;
#pragma warning disable 0169
		static Delegate GetGetBrandIdHandler ()
		{
			if (cb_getBrandId == null)
				cb_getBrandId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBrandId);
			return cb_getBrandId;
		}

		static IntPtr n_GetBrandId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BrandId);
		}
#pragma warning restore 0169

		static Delegate cb_setBrandId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBrandId_Ljava_lang_String_Handler ()
		{
			if (cb_setBrandId_Ljava_lang_String_ == null)
				cb_setBrandId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBrandId_Ljava_lang_String_);
			return cb_setBrandId_Ljava_lang_String_;
		}

		static void n_SetBrandId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BrandId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBrandId;
		static IntPtr id_setBrandId_Ljava_lang_String_;
		public virtual unsafe string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='getBrandId' and count(parameter)=0]"
			[Register ("getBrandId", "()Ljava/lang/String;", "GetGetBrandIdHandler")]
			get {
				if (id_getBrandId == IntPtr.Zero)
					id_getBrandId = JNIEnv.GetMethodID (class_ref, "getBrandId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBrandId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='setBrandId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBrandId", "(Ljava/lang/String;)V", "GetSetBrandId_Ljava_lang_String_Handler")]
			set {
				if (id_setBrandId_Ljava_lang_String_ == IntPtr.Zero)
					id_setBrandId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBrandId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrandId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrandId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFirstName;
#pragma warning disable 0169
		static Delegate GetGetFirstNameHandler ()
		{
			if (cb_getFirstName == null)
				cb_getFirstName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstName);
			return cb_getFirstName;
		}

		static IntPtr n_GetFirstName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		static Delegate cb_setFirstName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirstName_Ljava_lang_String_Handler ()
		{
			if (cb_setFirstName_Ljava_lang_String_ == null)
				cb_setFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstName_Ljava_lang_String_);
			return cb_setFirstName_Ljava_lang_String_;
		}

		static void n_SetFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FirstName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstName;
		static IntPtr id_setFirstName_Ljava_lang_String_;
		public virtual unsafe string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler")]
			get {
				if (id_getFirstName == IntPtr.Zero)
					id_getFirstName = JNIEnv.GetMethodID (class_ref, "getFirstName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='setFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirstName", "(Ljava/lang/String;)V", "GetSetFirstName_Ljava_lang_String_Handler")]
			set {
				if (id_setFirstName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFirstName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFirstName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Ljava_lang_String_;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessageType;
#pragma warning disable 0169
		static Delegate GetGetMessageTypeHandler ()
		{
			if (cb_getMessageType == null)
				cb_getMessageType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageType);
			return cb_getMessageType;
		}

		static IntPtr n_GetMessageType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessageType);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
#pragma warning disable 0169
		static Delegate GetSetMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler ()
		{
			if (cb_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == null)
				cb_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_);
			return cb_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		}

		static void n_SetMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageType;
		static IntPtr id_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		public virtual unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType MessageType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='getMessageType' and count(parameter)=0]"
			[Register ("getMessageType", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "GetGetMessageTypeHandler")]
			get {
				if (id_getMessageType == IntPtr.Zero)
					id_getMessageType = JNIEnv.GetMethodID (class_ref, "getMessageType", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageType", "()Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='setMessageType' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
			[Register ("setMessageType", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V", "GetSetMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler")]
			set {
				if (id_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
					id_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "setMessageType", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageType", "(Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_fromCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='MessagingSearchedMessage']/method[@name='fromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("fromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/messaging/model/MessagingSearchedMessage;", "")]
		public static unsafe global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage FromCursor (global::Android.Database.ICursor p0)
		{
			if (id_fromCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_fromCursor_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "fromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/messaging/model/MessagingSearchedMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingSearchedMessage> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCursor_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
