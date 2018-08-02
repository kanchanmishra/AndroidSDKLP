using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsUsers", DoNotGenerateAcw=true)]
	public partial class AmsUsers : global::Com.Liveperson.Infra.Database.BaseDBRepository, global::Com.Liveperson.Infra.IClearable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='BRAND_ID_EXTRA']"
		[Register ("BRAND_ID_EXTRA")]
		public const string BrandIdExtra = (string) "BRAND_ID_EXTRA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='BROADCAST_AGENT_CHANGED']"
		[Register ("BROADCAST_AGENT_CHANGED")]
		public const string BroadcastAgentChanged = (string) "BROADCAST_AGENT_CHANGED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='BROADCAST_CONSUMER_CHANGED']"
		[Register ("BROADCAST_CONSUMER_CHANGED")]
		public const string BroadcastConsumerChanged = (string) "BROADCAST_CONSUMER_CHANGED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='BROADCAST_CONSUMER_ID_ACTION']"
		[Register ("BROADCAST_CONSUMER_ID_ACTION")]
		public const string BroadcastConsumerIdAction = (string) "BROADCAST_CONSUMER_ID_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='EXTRA_KEY_AGENT_FULL_NAME']"
		[Register ("EXTRA_KEY_AGENT_FULL_NAME")]
		public const string ExtraKeyAgentFullName = (string) "EXTRA_KEY_AGENT_FULL_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='EXTRA_KEY_AGENT_NICKNAME']"
		[Register ("EXTRA_KEY_AGENT_NICKNAME")]
		public const string ExtraKeyAgentNickname = (string) "EXTRA_KEY_AGENT_NICKNAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='EXTRA_KEY_AGENT_SERVER_ID']"
		[Register ("EXTRA_KEY_AGENT_SERVER_ID")]
		public const string ExtraKeyAgentServerId = (string) "EXTRA_KEY_AGENT_SERVER_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='EXTRA_KEY_FULL_NAME']"
		[Register ("EXTRA_KEY_FULL_NAME")]
		public const string ExtraKeyFullName = (string) "EXTRA_KEY_FULL_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/field[@name='EXTRA_KEY_ID']"
		[Register ("EXTRA_KEY_ID")]
		public const string ExtraKeyId = (string) "EXTRA_KEY_ID";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsUsers", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsUsers); }
		}

		protected AmsUsers (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/constructor[@name='AmsUsers' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AmsUsers ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AmsUsers)) {
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

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearConsumerFromDB_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearConsumerFromDB_Ljava_lang_String_Handler ()
		{
			if (cb_clearConsumerFromDB_Ljava_lang_String_ == null)
				cb_clearConsumerFromDB_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearConsumerFromDB_Ljava_lang_String_);
			return cb_clearConsumerFromDB_Ljava_lang_String_;
		}

		static void n_ClearConsumerFromDB_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearConsumerFromDB (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clearConsumerFromDB_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='clearConsumerFromDB' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearConsumerFromDB", "(Ljava/lang/String;)V", "GetClearConsumerFromDB_Ljava_lang_String_Handler")]
		public virtual unsafe void ClearConsumerFromDB (string p0)
		{
			if (id_clearConsumerFromDB_Ljava_lang_String_ == IntPtr.Zero)
				id_clearConsumerFromDB_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearConsumerFromDB", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearConsumerFromDB_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearConsumerFromDB", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConsumerByBrandIDFromDB_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConsumerByBrandIDFromDB_Ljava_lang_String_Handler ()
		{
			if (cb_getConsumerByBrandIDFromDB_Ljava_lang_String_ == null)
				cb_getConsumerByBrandIDFromDB_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConsumerByBrandIDFromDB_Ljava_lang_String_);
			return cb_getConsumerByBrandIDFromDB_Ljava_lang_String_;
		}

		static IntPtr n_GetConsumerByBrandIDFromDB_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConsumerByBrandIDFromDB (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConsumerByBrandIDFromDB_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='getConsumerByBrandIDFromDB' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConsumerByBrandIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetConsumerByBrandIDFromDB_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetConsumerByBrandIDFromDB (string p0)
		{
			if (id_getConsumerByBrandIDFromDB_Ljava_lang_String_ == IntPtr.Zero)
				id_getConsumerByBrandIDFromDB_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConsumerByBrandIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConsumerByBrandIDFromDB_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConsumerByBrandIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getConsumerId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConsumerId_Ljava_lang_String_Handler ()
		{
			if (cb_getConsumerId_Ljava_lang_String_ == null)
				cb_getConsumerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConsumerId_Ljava_lang_String_);
			return cb_getConsumerId_Ljava_lang_String_;
		}

		static IntPtr n_GetConsumerId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetConsumerId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConsumerId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='getConsumerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConsumerId", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetConsumerId_Ljava_lang_String_Handler")]
		public virtual unsafe string GetConsumerId (string p0)
		{
			if (id_getConsumerId_Ljava_lang_String_ == IntPtr.Zero)
				id_getConsumerId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getConsumerId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConsumerId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConsumerId", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getProfileFromCursor_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetGetProfileFromCursor_Landroid_database_Cursor_Handler ()
		{
			if (cb_getProfileFromCursor_Landroid_database_Cursor_ == null)
				cb_getProfileFromCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetProfileFromCursor_Landroid_database_Cursor_);
			return cb_getProfileFromCursor_Landroid_database_Cursor_;
		}

		static IntPtr n_GetProfileFromCursor_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetProfileFromCursor (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProfileFromCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='getProfileFromCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getProfileFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/messaging/model/MessagingUserProfile;", "GetGetProfileFromCursor_Landroid_database_Cursor_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.MessagingUserProfile GetProfileFromCursor (global::Android.Database.ICursor p0)
		{
			if (id_getProfileFromCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getProfileFromCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "getProfileFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/messaging/model/MessagingUserProfile;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Messaging.Model.MessagingUserProfile __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProfileFromCursor_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProfileFromCursor", "(Landroid/database/Cursor;)Lcom/liveperson/messaging/model/MessagingUserProfile;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getProjection;
#pragma warning disable 0169
		static Delegate GetGetProjectionHandler ()
		{
			if (cb_getProjection == null)
				cb_getProjection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjection);
			return cb_getProjection;
		}

		static IntPtr n_GetProjection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetProjection ());
		}
#pragma warning restore 0169

		static IntPtr id_getProjection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='getProjection' and count(parameter)=0]"
		[Register ("getProjection", "()[Ljava/lang/String;", "GetGetProjectionHandler")]
		public virtual unsafe string[] GetProjection ()
		{
			if (id_getProjection == IntPtr.Zero)
				id_getProjection = JNIEnv.GetMethodID (class_ref, "getProjection", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProjection), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProjection", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getUserByBrandIDFromDB_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUserByBrandIDFromDB_Ljava_lang_String_Handler ()
		{
			if (cb_getUserByBrandIDFromDB_Ljava_lang_String_ == null)
				cb_getUserByBrandIDFromDB_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUserByBrandIDFromDB_Ljava_lang_String_);
			return cb_getUserByBrandIDFromDB_Ljava_lang_String_;
		}

		static IntPtr n_GetUserByBrandIDFromDB_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUserByBrandIDFromDB (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUserByBrandIDFromDB_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='getUserByBrandIDFromDB' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUserByBrandIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetUserByBrandIDFromDB_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetUserByBrandIDFromDB (string p0)
		{
			if (id_getUserByBrandIDFromDB_Ljava_lang_String_ == IntPtr.Zero)
				id_getUserByBrandIDFromDB_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUserByBrandIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserByBrandIDFromDB_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserByBrandIDFromDB", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUserById_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUserById_Ljava_lang_String_Handler ()
		{
			if (cb_getUserById_Ljava_lang_String_ == null)
				cb_getUserById_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUserById_Ljava_lang_String_);
			return cb_getUserById_Ljava_lang_String_;
		}

		static IntPtr n_GetUserById_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUserById (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUserById_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='getUserById' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUserById", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetUserById_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetUserById (string p0)
		{
			if (id_getUserById_Ljava_lang_String_ == IntPtr.Zero)
				id_getUserById_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUserById", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserById_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserById", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadConsumerForBrand_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadConsumerForBrand_Ljava_lang_String_Handler ()
		{
			if (cb_loadConsumerForBrand_Ljava_lang_String_ == null)
				cb_loadConsumerForBrand_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadConsumerForBrand_Ljava_lang_String_);
			return cb_loadConsumerForBrand_Ljava_lang_String_;
		}

		static void n_LoadConsumerForBrand_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadConsumerForBrand (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadConsumerForBrand_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='loadConsumerForBrand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadConsumerForBrand", "(Ljava/lang/String;)V", "GetLoadConsumerForBrand_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadConsumerForBrand (string p0)
		{
			if (id_loadConsumerForBrand_Ljava_lang_String_ == IntPtr.Zero)
				id_loadConsumerForBrand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadConsumerForBrand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadConsumerForBrand_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadConsumerForBrand", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_loadProfile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadProfile_Ljava_lang_String_Handler ()
		{
			if (cb_loadProfile_Ljava_lang_String_ == null)
				cb_loadProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadProfile_Ljava_lang_String_);
			return cb_loadProfile_Ljava_lang_String_;
		}

		static void n_LoadProfile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadProfile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadProfile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='loadProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadProfile", "(Ljava/lang/String;)V", "GetLoadProfile_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadProfile (string p0)
		{
			if (id_loadProfile_Ljava_lang_String_ == IntPtr.Zero)
				id_loadProfile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadProfile", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadProfile_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadProfile", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateConsumerId_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateConsumerId_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateConsumerId_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateConsumerId_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateConsumerId_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateConsumerId_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateConsumerId_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConsumerId (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateConsumerId_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='updateConsumerId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateConsumerId", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateConsumerId_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateConsumerId (string p0, string p1)
		{
			if (id_updateConsumerId_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateConsumerId_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateConsumerId", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConsumerId_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConsumerId", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_;
#pragma warning disable 0169
		static Delegate GetUpdateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_Handler ()
		{
			if (cb_updateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_ == null)
				cb_updateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_);
			return cb_updateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_;
		}

		static void n_UpdateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsUsers __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsUsers> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingUserProfile p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserProfile (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsUsers']/method[@name='updateUserProfile' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.MessagingUserProfile']]"
		[Register ("updateUserProfile", "(Lcom/liveperson/messaging/model/MessagingUserProfile;)V", "GetUpdateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_Handler")]
		public virtual unsafe void UpdateUserProfile (global::Com.Liveperson.Messaging.Model.MessagingUserProfile p0)
		{
			if (id_updateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_ == IntPtr.Zero)
				id_updateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_ = JNIEnv.GetMethodID (class_ref, "updateUserProfile", "(Lcom/liveperson/messaging/model/MessagingUserProfile;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserProfile_Lcom_liveperson_messaging_model_MessagingUserProfile_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserProfile", "(Lcom/liveperson/messaging/model/MessagingUserProfile;)V"), __args);
			} finally {
			}
		}

	}
}
