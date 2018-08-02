using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']"
	[Register ("com/liveperson/messaging/model/AmsMessagesLoaderProvider", "", "Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker")]
	public partial interface IAmsMessagesLoaderProvider : IJavaObject {

		bool HasListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']/method[@name='hasListener' and count(parameter)=0]"
			[Register ("hasListener", "()Z", "GetHasListenerHandler:Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']/method[@name='addOnUpdateListener' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.model.AmsMessages.MessagesListener'] and parameter[2][@type='com.liveperson.messaging.model.AmsMessages.MessagesSortedBy'] and parameter[3][@type='java.lang.String']]"
		[Register ("addOnUpdateListener", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesListener;Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;)V", "GetAddOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker, LP_Android_aar_Binding")]
		void AddOnUpdateListener (global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener p0, global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']/method[@name='getMyUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMyUserId", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMyUserId_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker, LP_Android_aar_Binding")]
		string GetMyUserId (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']/method[@name='getQuickRepliesMessageHolder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getQuickRepliesMessageHolder", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;", "GetGetQuickRepliesMessageHolder_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker, LP_Android_aar_Binding")]
		global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder GetQuickRepliesMessageHolder (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']/method[@name='loadMessages' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.model.AmsMessages.MessagesSortedBy'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("loadMessages", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;IJJ)Lcom/liveperson/infra/database/DataBaseCommand;", "GetLoadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJHandler:Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker, LP_Android_aar_Binding")]
		global::Com.Liveperson.Infra.Database.DataBaseCommand LoadMessages (global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p0, string p1, int p2, long p3, long p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']/method[@name='loadMessagingUserProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadMessagingUserProfile", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingUserProfile;", "GetLoadMessagingUserProfile_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker, LP_Android_aar_Binding")]
		global::Com.Liveperson.Messaging.Model.MessagingUserProfile LoadMessagingUserProfile (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']/method[@name='removeOnUpdateListener' and count(parameter)=0]"
		[Register ("removeOnUpdateListener", "()V", "GetRemoveOnUpdateListenerHandler:Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker, LP_Android_aar_Binding")]
		void RemoveOnUpdateListener ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessagesLoaderProvider']/method[@name='resetQuickRepliesMessageHolder' and count(parameter)=0]"
		[Register ("resetQuickRepliesMessageHolder", "()V", "GetResetQuickRepliesMessageHolderHandler:Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProviderInvoker, LP_Android_aar_Binding")]
		void ResetQuickRepliesMessageHolder ();

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsMessagesLoaderProvider", DoNotGenerateAcw=true)]
	internal class IAmsMessagesLoaderProviderInvoker : global::Java.Lang.Object, IAmsMessagesLoaderProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/model/AmsMessagesLoaderProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAmsMessagesLoaderProviderInvoker); }
		}

		IntPtr class_ref;

		public static IAmsMessagesLoaderProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAmsMessagesLoaderProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.model.AmsMessagesLoaderProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAmsMessagesLoaderProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_hasListener;
#pragma warning disable 0169
		static Delegate GetHasListenerHandler ()
		{
			if (cb_hasListener == null)
				cb_hasListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasListener);
			return cb_hasListener;
		}

		static bool n_HasListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasListener;
		}
#pragma warning restore 0169

		IntPtr id_hasListener;
		public unsafe bool HasListener {
			get {
				if (id_hasListener == IntPtr.Zero)
					id_hasListener = JNIEnv.GetMethodID (class_ref, "hasListener", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasListener);
			}
		}

		static Delegate cb_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_Handler ()
		{
			if (cb_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_ == null)
				cb_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_);
			return cb_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_;
		}

		static void n_AddOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener p0 = (global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddOnUpdateListener (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_;
		public unsafe void AddOnUpdateListener (global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener p0, global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p1, string p2)
		{
			if (id_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_ == IntPtr.Zero)
				id_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addOnUpdateListener", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesListener;Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getMyUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMyUserId_Ljava_lang_String_Handler ()
		{
			if (cb_getMyUserId_Ljava_lang_String_ == null)
				cb_getMyUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMyUserId_Ljava_lang_String_);
			return cb_getMyUserId_Ljava_lang_String_;
		}

		static IntPtr n_GetMyUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMyUserId (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMyUserId_Ljava_lang_String_;
		public unsafe string GetMyUserId (string p0)
		{
			if (id_getMyUserId_Ljava_lang_String_ == IntPtr.Zero)
				id_getMyUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMyUserId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMyUserId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getQuickRepliesMessageHolder_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetQuickRepliesMessageHolder_Ljava_lang_String_Handler ()
		{
			if (cb_getQuickRepliesMessageHolder_Ljava_lang_String_ == null)
				cb_getQuickRepliesMessageHolder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetQuickRepliesMessageHolder_Ljava_lang_String_);
			return cb_getQuickRepliesMessageHolder_Ljava_lang_String_;
		}

		static IntPtr n_GetQuickRepliesMessageHolder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetQuickRepliesMessageHolder (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getQuickRepliesMessageHolder_Ljava_lang_String_;
		public unsafe global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder GetQuickRepliesMessageHolder (string p0)
		{
			if (id_getQuickRepliesMessageHolder_Ljava_lang_String_ == IntPtr.Zero)
				id_getQuickRepliesMessageHolder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getQuickRepliesMessageHolder", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQuickRepliesMessageHolder_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ;
#pragma warning disable 0169
		static Delegate GetLoadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJHandler ()
		{
			if (cb_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ == null)
				cb_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, long, long, IntPtr>) n_LoadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ);
			return cb_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ;
		}

		static IntPtr n_LoadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3, long p4)
		{
			global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadMessages (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ;
		public unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand LoadMessages (global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p0, string p1, int p2, long p3, long p4)
		{
			if (id_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ == IntPtr.Zero)
				id_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ = JNIEnv.GetMethodID (class_ref, "loadMessages", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;IJJ)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			global::Com.Liveperson.Infra.Database.DataBaseCommand __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_loadMessagingUserProfile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadMessagingUserProfile_Ljava_lang_String_Handler ()
		{
			if (cb_loadMessagingUserProfile_Ljava_lang_String_ == null)
				cb_loadMessagingUserProfile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadMessagingUserProfile_Ljava_lang_String_);
			return cb_loadMessagingUserProfile_Ljava_lang_String_;
		}

		static IntPtr n_LoadMessagingUserProfile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadMessagingUserProfile (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadMessagingUserProfile_Ljava_lang_String_;
		public unsafe global::Com.Liveperson.Messaging.Model.MessagingUserProfile LoadMessagingUserProfile (string p0)
		{
			if (id_loadMessagingUserProfile_Ljava_lang_String_ == IntPtr.Zero)
				id_loadMessagingUserProfile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadMessagingUserProfile", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingUserProfile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Liveperson.Messaging.Model.MessagingUserProfile __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadMessagingUserProfile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_removeOnUpdateListener;
#pragma warning disable 0169
		static Delegate GetRemoveOnUpdateListenerHandler ()
		{
			if (cb_removeOnUpdateListener == null)
				cb_removeOnUpdateListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveOnUpdateListener);
			return cb_removeOnUpdateListener;
		}

		static void n_RemoveOnUpdateListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnUpdateListener ();
		}
#pragma warning restore 0169

		IntPtr id_removeOnUpdateListener;
		public unsafe void RemoveOnUpdateListener ()
		{
			if (id_removeOnUpdateListener == IntPtr.Zero)
				id_removeOnUpdateListener = JNIEnv.GetMethodID (class_ref, "removeOnUpdateListener", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOnUpdateListener);
		}

		static Delegate cb_resetQuickRepliesMessageHolder;
#pragma warning disable 0169
		static Delegate GetResetQuickRepliesMessageHolderHandler ()
		{
			if (cb_resetQuickRepliesMessageHolder == null)
				cb_resetQuickRepliesMessageHolder = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetQuickRepliesMessageHolder);
			return cb_resetQuickRepliesMessageHolder;
		}

		static void n_ResetQuickRepliesMessageHolder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetQuickRepliesMessageHolder ();
		}
#pragma warning restore 0169

		IntPtr id_resetQuickRepliesMessageHolder;
		public unsafe void ResetQuickRepliesMessageHolder ()
		{
			if (id_resetQuickRepliesMessageHolder == IntPtr.Zero)
				id_resetQuickRepliesMessageHolder = JNIEnv.GetMethodID (class_ref, "resetQuickRepliesMessageHolder", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetQuickRepliesMessageHolder);
		}

	}

}
