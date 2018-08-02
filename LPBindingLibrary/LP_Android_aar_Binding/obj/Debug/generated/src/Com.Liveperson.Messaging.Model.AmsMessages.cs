using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsMessages", DoNotGenerateAcw=true)]
	public partial class AmsMessages : global::Com.Liveperson.Infra.Database.BaseDBRepository, global::Com.Liveperson.Infra.IClearable, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown, global::Com.Liveperson.Messaging.Model.IAmsMessagesLoaderProvider {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/field[@name='MASKED_CC_MSG_SEQUENCE_NUMBER']"
		[Register ("MASKED_CC_MSG_SEQUENCE_NUMBER")]
		public const int MaskedCcMsgSequenceNumber = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/field[@name='PENDING_MSG_SEQUENCE_NUMBER']"
		[Register ("PENDING_MSG_SEQUENCE_NUMBER")]
		public const int PendingMsgSequenceNumber = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/field[@name='RESOLVE_MSG_SEQUENCE_NUMBER']"
		[Register ("RESOLVE_MSG_SEQUENCE_NUMBER")]
		public const int ResolveMsgSequenceNumber = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/field[@name='STRUCTURED_CONTENT_PREFIX']"
		[Register ("STRUCTURED_CONTENT_PREFIX")]
		public const string StructuredContentPrefix = (string) "lpsc:";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/field[@name='WELCOME_MSG_SEQUENCE_NUMBER']"
		[Register ("WELCOME_MSG_SEQUENCE_NUMBER")]
		public const int WelcomeMsgSequenceNumber = (int) -4;

		static IntPtr mFormsManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/field[@name='mFormsManager']"
		[Register ("mFormsManager")]
		public global::Com.Liveperson.Messaging.Model.FormsManager MFormsManager {
			get {
				if (mFormsManager_jfieldId == IntPtr.Zero)
					mFormsManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mFormsManager", "Lcom/liveperson/messaging/model/FormsManager;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFormsManager_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FormsManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFormsManager_jfieldId == IntPtr.Zero)
					mFormsManager_jfieldId = JNIEnv.GetFieldID (class_ref, "mFormsManager", "Lcom/liveperson/messaging/model/FormsManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFormsManager_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMessageTimeoutQueue_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/field[@name='mMessageTimeoutQueue']"
		[Register ("mMessageTimeoutQueue")]
		public global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue MMessageTimeoutQueue {
			get {
				if (mMessageTimeoutQueue_jfieldId == IntPtr.Zero)
					mMessageTimeoutQueue_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageTimeoutQueue", "Lcom/liveperson/messaging/network/MessageTimeoutQueue;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMessageTimeoutQueue_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMessageTimeoutQueue_jfieldId == IntPtr.Zero)
					mMessageTimeoutQueue_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageTimeoutQueue", "Lcom/liveperson/messaging/network/MessageTimeoutQueue;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageTimeoutQueue_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']"
		[Register ("com/liveperson/messaging/model/AmsMessages$MessagesListener", "", "Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker")]
		public partial interface IMessagesListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='initMessages' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.liveperson.messaging.model.FullMessageRow&gt;']]"
			[Register ("initMessages", "(Ljava/util/ArrayList;)V", "GetInitMessages_Ljava_util_ArrayList_Handler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void InitMessages (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.FullMessageRow> p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='onExConversationHandled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onExConversationHandled", "(Z)V", "GetOnExConversationHandled_ZHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void OnExConversationHandled (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='onHistoryFetched' and count(parameter)=0]"
			[Register ("onHistoryFetched", "()V", "GetOnHistoryFetchedHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void OnHistoryFetched ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='onHistoryFetchedFailed' and count(parameter)=0]"
			[Register ("onHistoryFetchedFailed", "()V", "GetOnHistoryFetchedFailedHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void OnHistoryFetchedFailed ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='onNewMessage' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.FullMessageRow']]"
			[Register ("onNewMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V", "GetOnNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_Handler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void OnNewMessage (global::Com.Liveperson.Messaging.Model.FullMessageRow p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='onQueryMessagesResult' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("onQueryMessagesResult", "(JJ)V", "GetOnQueryMessagesResult_JJHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void OnQueryMessagesResult (long p0, long p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='onUpdateMessage' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.FullMessageRow']]"
			[Register ("onUpdateMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V", "GetOnUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_Handler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void OnUpdateMessage (global::Com.Liveperson.Messaging.Model.FullMessageRow p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='onUpdateMessages' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("onUpdateMessages", "(JJ)V", "GetOnUpdateMessages_JJHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void OnUpdateMessages (long p0, long p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/interface[@name='AmsMessages.MessagesListener']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeAll", "(Ljava/lang/String;)V", "GetRemoveAll_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding")]
			void RemoveAll (string p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsMessages$MessagesListener", DoNotGenerateAcw=true)]
		internal class IMessagesListenerInvoker : global::Java.Lang.Object, IMessagesListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/model/AmsMessages$MessagesListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IMessagesListenerInvoker); }
			}

			IntPtr class_ref;

			public static IMessagesListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMessagesListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.model.AmsMessages.MessagesListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMessagesListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_initMessages_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetInitMessages_Ljava_util_ArrayList_Handler ()
			{
				if (cb_initMessages_Ljava_util_ArrayList_ == null)
					cb_initMessages_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitMessages_Ljava_util_ArrayList_);
				return cb_initMessages_Ljava_util_ArrayList_;
			}

			static void n_InitMessages_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.FullMessageRow>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.InitMessages (p0);
			}
#pragma warning restore 0169

			IntPtr id_initMessages_Ljava_util_ArrayList_;
			public unsafe void InitMessages (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.FullMessageRow> p0)
			{
				if (id_initMessages_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_initMessages_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "initMessages", "(Ljava/util/ArrayList;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.FullMessageRow>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initMessages_Ljava_util_ArrayList_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onExConversationHandled_Z;
#pragma warning disable 0169
			static Delegate GetOnExConversationHandled_ZHandler ()
			{
				if (cb_onExConversationHandled_Z == null)
					cb_onExConversationHandled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnExConversationHandled_Z);
				return cb_onExConversationHandled_Z;
			}

			static void n_OnExConversationHandled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnExConversationHandled (p0);
			}
#pragma warning restore 0169

			IntPtr id_onExConversationHandled_Z;
			public unsafe void OnExConversationHandled (bool p0)
			{
				if (id_onExConversationHandled_Z == IntPtr.Zero)
					id_onExConversationHandled_Z = JNIEnv.GetMethodID (class_ref, "onExConversationHandled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onExConversationHandled_Z, __args);
			}

			static Delegate cb_onHistoryFetched;
#pragma warning disable 0169
			static Delegate GetOnHistoryFetchedHandler ()
			{
				if (cb_onHistoryFetched == null)
					cb_onHistoryFetched = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnHistoryFetched);
				return cb_onHistoryFetched;
			}

			static void n_OnHistoryFetched (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnHistoryFetched ();
			}
#pragma warning restore 0169

			IntPtr id_onHistoryFetched;
			public unsafe void OnHistoryFetched ()
			{
				if (id_onHistoryFetched == IntPtr.Zero)
					id_onHistoryFetched = JNIEnv.GetMethodID (class_ref, "onHistoryFetched", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHistoryFetched);
			}

			static Delegate cb_onHistoryFetchedFailed;
#pragma warning disable 0169
			static Delegate GetOnHistoryFetchedFailedHandler ()
			{
				if (cb_onHistoryFetchedFailed == null)
					cb_onHistoryFetchedFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnHistoryFetchedFailed);
				return cb_onHistoryFetchedFailed;
			}

			static void n_OnHistoryFetchedFailed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnHistoryFetchedFailed ();
			}
#pragma warning restore 0169

			IntPtr id_onHistoryFetchedFailed;
			public unsafe void OnHistoryFetchedFailed ()
			{
				if (id_onHistoryFetchedFailed == IntPtr.Zero)
					id_onHistoryFetchedFailed = JNIEnv.GetMethodID (class_ref, "onHistoryFetchedFailed", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHistoryFetchedFailed);
			}

			static Delegate cb_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_;
#pragma warning disable 0169
			static Delegate GetOnNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_Handler ()
			{
				if (cb_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_ == null)
					cb_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_);
				return cb_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_;
			}

			static void n_OnNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Messaging.Model.FullMessageRow p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnNewMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_;
			public unsafe void OnNewMessage (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
			{
				if (id_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
					id_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetMethodID (class_ref, "onNewMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_, __args);
			}

			static Delegate cb_onQueryMessagesResult_JJ;
#pragma warning disable 0169
			static Delegate GetOnQueryMessagesResult_JJHandler ()
			{
				if (cb_onQueryMessagesResult_JJ == null)
					cb_onQueryMessagesResult_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_OnQueryMessagesResult_JJ);
				return cb_onQueryMessagesResult_JJ;
			}

			static void n_OnQueryMessagesResult_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryMessagesResult (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onQueryMessagesResult_JJ;
			public unsafe void OnQueryMessagesResult (long p0, long p1)
			{
				if (id_onQueryMessagesResult_JJ == IntPtr.Zero)
					id_onQueryMessagesResult_JJ = JNIEnv.GetMethodID (class_ref, "onQueryMessagesResult", "(JJ)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onQueryMessagesResult_JJ, __args);
			}

			static Delegate cb_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_;
#pragma warning disable 0169
			static Delegate GetOnUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_Handler ()
			{
				if (cb_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_ == null)
					cb_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_);
				return cb_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_;
			}

			static void n_OnUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Messaging.Model.FullMessageRow p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdateMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_;
			public unsafe void OnUpdateMessage (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
			{
				if (id_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
					id_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetMethodID (class_ref, "onUpdateMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_, __args);
			}

			static Delegate cb_onUpdateMessages_JJ;
#pragma warning disable 0169
			static Delegate GetOnUpdateMessages_JJHandler ()
			{
				if (cb_onUpdateMessages_JJ == null)
					cb_onUpdateMessages_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_OnUpdateMessages_JJ);
				return cb_onUpdateMessages_JJ;
			}

			static void n_OnUpdateMessages_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdateMessages (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onUpdateMessages_JJ;
			public unsafe void OnUpdateMessages (long p0, long p1)
			{
				if (id_onUpdateMessages_JJ == IntPtr.Zero)
					id_onUpdateMessages_JJ = JNIEnv.GetMethodID (class_ref, "onUpdateMessages", "(JJ)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateMessages_JJ, __args);
			}

			static Delegate cb_removeAll_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemoveAll_Ljava_lang_String_Handler ()
			{
				if (cb_removeAll_Ljava_lang_String_ == null)
					cb_removeAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveAll_Ljava_lang_String_);
				return cb_removeAll_Ljava_lang_String_;
			}

			static void n_RemoveAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RemoveAll (p0);
			}
#pragma warning restore 0169

			IntPtr id_removeAll_Ljava_lang_String_;
			public unsafe void RemoveAll (string p0)
			{
				if (id_removeAll_Ljava_lang_String_ == IntPtr.Zero)
					id_removeAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class InitMessagesEventArgs : global::System.EventArgs {

			public InitMessagesEventArgs (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.FullMessageRow> p0)
			{
				this.p0 = p0;
			}

			global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.FullMessageRow> p0;
			public global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.FullMessageRow> P0 {
				get { return p0; }
			}
		}

		public partial class ExConversationHandledEventArgs : global::System.EventArgs {

			public ExConversationHandledEventArgs (bool p0)
			{
				this.p0 = p0;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}
		}

		public partial class NewMessageEventArgs : global::System.EventArgs {

			public NewMessageEventArgs (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
			{
				this.p0 = p0;
			}

			global::Com.Liveperson.Messaging.Model.FullMessageRow p0;
			public global::Com.Liveperson.Messaging.Model.FullMessageRow P0 {
				get { return p0; }
			}
		}

		public partial class QueryMessagesResultEventArgs : global::System.EventArgs {

			public QueryMessagesResultEventArgs (long p0, long p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			long p0;
			public long P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}
		}

		public partial class UpdateMessageEventArgs : global::System.EventArgs {

			public UpdateMessageEventArgs (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
			{
				this.p0 = p0;
			}

			global::Com.Liveperson.Messaging.Model.FullMessageRow p0;
			public global::Com.Liveperson.Messaging.Model.FullMessageRow P0 {
				get { return p0; }
			}
		}

		public partial class UpdateMessagesEventArgs : global::System.EventArgs {

			public UpdateMessagesEventArgs (long p0, long p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			long p0;
			public long P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}
		}

		public partial class RemoveAllEventArgs : global::System.EventArgs {

			public RemoveAllEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/liveperson/messaging/model/AmsMessages_MessagesListenerImplementor")]
		internal sealed partial class IMessagesListenerImplementor : global::Java.Lang.Object, IMessagesListener {

			object sender;

			public IMessagesListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/messaging/model/AmsMessages_MessagesListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InitMessagesEventArgs> InitMessagesHandler;
#pragma warning restore 0649

			public void InitMessages (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.FullMessageRow> p0)
			{
				var __h = InitMessagesHandler;
				if (__h != null)
					__h (sender, new InitMessagesEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<ExConversationHandledEventArgs> OnExConversationHandledHandler;
#pragma warning restore 0649

			public void OnExConversationHandled (bool p0)
			{
				var __h = OnExConversationHandledHandler;
				if (__h != null)
					__h (sender, new ExConversationHandledEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnHistoryFetchedHandler;
#pragma warning restore 0649

			public void OnHistoryFetched ()
			{
				var __h = OnHistoryFetchedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnHistoryFetchedFailedHandler;
#pragma warning restore 0649

			public void OnHistoryFetchedFailed ()
			{
				var __h = OnHistoryFetchedFailedHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<NewMessageEventArgs> OnNewMessageHandler;
#pragma warning restore 0649

			public void OnNewMessage (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
			{
				var __h = OnNewMessageHandler;
				if (__h != null)
					__h (sender, new NewMessageEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<QueryMessagesResultEventArgs> OnQueryMessagesResultHandler;
#pragma warning restore 0649

			public void OnQueryMessagesResult (long p0, long p1)
			{
				var __h = OnQueryMessagesResultHandler;
				if (__h != null)
					__h (sender, new QueryMessagesResultEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<UpdateMessageEventArgs> OnUpdateMessageHandler;
#pragma warning restore 0649

			public void OnUpdateMessage (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
			{
				var __h = OnUpdateMessageHandler;
				if (__h != null)
					__h (sender, new UpdateMessageEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<UpdateMessagesEventArgs> OnUpdateMessagesHandler;
#pragma warning restore 0649

			public void OnUpdateMessages (long p0, long p1)
			{
				var __h = OnUpdateMessagesHandler;
				if (__h != null)
					__h (sender, new UpdateMessagesEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RemoveAllEventArgs> RemoveAllHandler;
#pragma warning restore 0649

			public void RemoveAll (string p0)
			{
				var __h = RemoveAllHandler;
				if (__h != null)
					__h (sender, new RemoveAllEventArgs (p0));
			}

			internal static bool __IsEmpty (IMessagesListenerImplementor value)
			{
				return value.InitMessagesHandler == null && value.OnExConversationHandledHandler == null && value.OnHistoryFetchedHandler == null && value.OnHistoryFetchedFailedHandler == null && value.OnNewMessageHandler == null && value.OnQueryMessagesResultHandler == null && value.OnUpdateMessageHandler == null && value.OnUpdateMessagesHandler == null && value.RemoveAllHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages.MessagesSortedBy']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/model/AmsMessages$MessagesSortedBy", DoNotGenerateAcw=true)]
		public sealed partial class MessagesSortedBy : global::Java.Lang.Enum {


			static IntPtr ConversationId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages.MessagesSortedBy']/field[@name='ConversationId']"
			[Register ("ConversationId")]
			public static global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy ConversationId {
				get {
					if (ConversationId_jfieldId == IntPtr.Zero)
						ConversationId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ConversationId", "Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ConversationId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TargetId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages.MessagesSortedBy']/field[@name='TargetId']"
			[Register ("TargetId")]
			public static global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy TargetId {
				get {
					if (TargetId_jfieldId == IntPtr.Zero)
						TargetId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TargetId", "Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TargetId_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsMessages$MessagesSortedBy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessagesSortedBy); }
			}

			internal MessagesSortedBy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages.MessagesSortedBy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages.MessagesSortedBy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;");
				try {
					return (global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/AmsMessages", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AmsMessages); }
		}

		protected AmsMessages (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/constructor[@name='AmsMessages' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe AmsMessages (global::Com.Liveperson.Messaging.Messaging p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AmsMessages)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_, __args);
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasListener;
		}
#pragma warning restore 0169

		static IntPtr id_hasListener;
		public virtual unsafe bool HasListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='hasListener' and count(parameter)=0]"
			[Register ("hasListener", "()Z", "GetHasListenerHandler")]
			get {
				if (id_hasListener == IntPtr.Zero)
					id_hasListener = JNIEnv.GetMethodID (class_ref, "hasListener", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasListener);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasListener", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessages;
#pragma warning disable 0169
		static Delegate GetGetMessagesHandler ()
		{
			if (cb_getMessages == null)
				cb_getMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessages);
			return cb_getMessages;
		}

		static IntPtr n_GetMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Messages);
		}
#pragma warning restore 0169

		static IntPtr id_getMessages;
		public virtual unsafe global::Android.Database.ICursor Messages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='getMessages' and count(parameter)=0]"
			[Register ("getMessages", "()Landroid/database/Cursor;", "GetGetMessagesHandler")]
			get {
				if (id_getMessages == IntPtr.Zero)
					id_getMessages = JNIEnv.GetMethodID (class_ref, "getMessages", "()Landroid/database/Cursor;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "()Landroid/database/Cursor;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeOfFirstMessage;
#pragma warning disable 0169
		static Delegate GetGetTimeOfFirstMessageHandler ()
		{
			if (cb_getTimeOfFirstMessage == null)
				cb_getTimeOfFirstMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeOfFirstMessage);
			return cb_getTimeOfFirstMessage;
		}

		static IntPtr n_GetTimeOfFirstMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeOfFirstMessage);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeOfFirstMessage;
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand TimeOfFirstMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='getTimeOfFirstMessage' and count(parameter)=0]"
			[Register ("getTimeOfFirstMessage", "()Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetTimeOfFirstMessageHandler")]
			get {
				if (id_getTimeOfFirstMessage == IntPtr.Zero)
					id_getTimeOfFirstMessage = JNIEnv.GetMethodID (class_ref, "getTimeOfFirstMessage", "()Lcom/liveperson/infra/database/DataBaseCommand;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeOfFirstMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeOfFirstMessage", "()Lcom/liveperson/infra/database/DataBaseCommand;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAddFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_ZHandler ()
		{
			if (cb_addFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z == null)
				cb_addFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr, bool>) n_AddFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z);
			return cb_addFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z;
		}

		static void n_AddFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Request.Message.FilePublishMessage p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.FilePublishMessage> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.AddFileFromPublishMessageToDB (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_addFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='addFileFromPublishMessageToDB' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.api.request.message.FilePublishMessage'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean']]"
		[Register ("addFileFromPublishMessageToDB", "(JLjava/lang/String;Lcom/liveperson/api/request/message/FilePublishMessage;Ljava/lang/String;Z)V", "GetAddFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_ZHandler")]
		public virtual unsafe void AddFileFromPublishMessageToDB (long p0, string p1, global::Com.Liveperson.Api.Request.Message.FilePublishMessage p2, string p3, bool p4)
		{
			if (id_addFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z == IntPtr.Zero)
				id_addFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "addFileFromPublishMessageToDB", "(JLjava/lang/String;Lcom/liveperson/api/request/message/FilePublishMessage;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFileFromPublishMessageToDB_JLjava_lang_String_Lcom_liveperson_api_request_message_FilePublishMessage_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFileFromPublishMessageToDB", "(JLjava/lang/String;Lcom/liveperson/api/request/message/FilePublishMessage;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_addMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z;
#pragma warning disable 0169
		static Delegate GetAddMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_ZHandler ()
		{
			if (cb_addMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z == null)
				cb_addMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_AddMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z);
			return cb_addMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z;
		}

		static IntPtr n_AddMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMessage (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='addMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage'] and parameter[3][@type='boolean']]"
		[Register ("addMessage", "(Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage;Z)Lcom/liveperson/infra/database/DataBaseCommand;", "GetAddMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_ZHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand AddMessage (string p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage p1, bool p2)
		{
			if (id_addMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z == IntPtr.Zero)
				id_addMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z = JNIEnv.GetMethodID (class_ref, "addMessage", "(Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage;Z)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMessage_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMessage", "(Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage;Z)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ;
#pragma warning disable 0169
		static Delegate GetAddMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZHandler ()
		{
			if (cb_addMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ == null)
				cb_addMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, bool, bool, IntPtr>) n_AddMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ);
			return cb_addMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ;
		}

		static IntPtr n_AddMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, long p5, bool p6, bool p7)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMultipleMessages (p0, p1, p2, p3, p4, p5, p6, p7));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='addMultipleMessages' and count(parameter)=8 and parameter[1][@type='java.util.ArrayList&lt;com.liveperson.api.response.events.ContentEventNotification&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='long'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean']]"
		[Register ("addMultipleMessages", "(Ljava/util/ArrayList;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JZZ)Lcom/liveperson/infra/database/DataBaseCommand;", "GetAddMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand AddMultipleMessages (global::System.Collections.Generic.IList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification> p0, string p1, string p2, string p3, string p4, long p5, bool p6, bool p7)
		{
			if (id_addMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ == IntPtr.Zero)
				id_addMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ = JNIEnv.GetMethodID (class_ref, "addMultipleMessages", "(Ljava/util/ArrayList;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JZZ)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Events.ContentEventNotification>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMultipleMessages_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JZZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMultipleMessages", "(Ljava/util/ArrayList;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JZZ)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener p0 = (global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddOnUpdateListener (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='addOnUpdateListener' and count(parameter)=3 and parameter[1][@type='com.liveperson.messaging.model.AmsMessages.MessagesListener'] and parameter[2][@type='com.liveperson.messaging.model.AmsMessages.MessagesSortedBy'] and parameter[3][@type='java.lang.String']]"
		[Register ("addOnUpdateListener", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesListener;Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;)V", "GetAddOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_Handler")]
		public virtual unsafe void AddOnUpdateListener (global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener p0, global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p1, string p2)
		{
			if (id_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_ == IntPtr.Zero)
				id_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addOnUpdateListener", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesListener;Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOnUpdateListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesListener_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnUpdateListener", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesListener;Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='clear' and count(parameter)=0]"
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

		static Delegate cb_clearAllClosedConversationMessages_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearAllClosedConversationMessages_Ljava_lang_String_Handler ()
		{
			if (cb_clearAllClosedConversationMessages_Ljava_lang_String_ == null)
				cb_clearAllClosedConversationMessages_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ClearAllClosedConversationMessages_Ljava_lang_String_);
			return cb_clearAllClosedConversationMessages_Ljava_lang_String_;
		}

		static IntPtr n_ClearAllClosedConversationMessages_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ClearAllClosedConversationMessages (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_clearAllClosedConversationMessages_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='clearAllClosedConversationMessages' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearAllClosedConversationMessages", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetClearAllClosedConversationMessages_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand ClearAllClosedConversationMessages (string p0)
		{
			if (id_clearAllClosedConversationMessages_Ljava_lang_String_ == IntPtr.Zero)
				id_clearAllClosedConversationMessages_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearAllClosedConversationMessages", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clearAllClosedConversationMessages_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAllClosedConversationMessages", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMessageByEventId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessageByEventId_Ljava_lang_String_Handler ()
		{
			if (cb_getMessageByEventId_Ljava_lang_String_ == null)
				cb_getMessageByEventId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageByEventId_Ljava_lang_String_);
			return cb_getMessageByEventId_Ljava_lang_String_;
		}

		static IntPtr n_GetMessageByEventId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessageByEventId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageByEventId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='getMessageByEventId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMessageByEventId", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetMessageByEventId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetMessageByEventId (string p0)
		{
			if (id_getMessageByEventId_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessageByEventId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessageByEventId", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageByEventId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageByEventId", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMyUserId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMyUserId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='getMyUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMyUserId", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMyUserId_Ljava_lang_String_Handler")]
		public virtual unsafe string GetMyUserId (string p0)
		{
			if (id_getMyUserId_Ljava_lang_String_ == IntPtr.Zero)
				id_getMyUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMyUserId", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMyUserId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMyUserId", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetQuickRepliesMessageHolder (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getQuickRepliesMessageHolder_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='getQuickRepliesMessageHolder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getQuickRepliesMessageHolder", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;", "GetGetQuickRepliesMessageHolder_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder GetQuickRepliesMessageHolder (string p0)
		{
			if (id_getQuickRepliesMessageHolder_Ljava_lang_String_ == IntPtr.Zero)
				id_getQuickRepliesMessageHolder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getQuickRepliesMessageHolder", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQuickRepliesMessageHolder_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.QuickRepliesMessageHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuickRepliesMessageHolder", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/QuickRepliesMessageHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getRowIdByEventId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRowIdByEventId_Ljava_lang_String_Handler ()
		{
			if (cb_getRowIdByEventId_Ljava_lang_String_ == null)
				cb_getRowIdByEventId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRowIdByEventId_Ljava_lang_String_);
			return cb_getRowIdByEventId_Ljava_lang_String_;
		}

		static IntPtr n_GetRowIdByEventId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRowIdByEventId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRowIdByEventId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='getRowIdByEventId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRowIdByEventId", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetRowIdByEventId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetRowIdByEventId (string p0)
		{
			if (id_getRowIdByEventId_Ljava_lang_String_ == IntPtr.Zero)
				id_getRowIdByEventId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRowIdByEventId", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRowIdByEventId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRowIdByEventId", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSequencesForConversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSequencesForConversation_Ljava_lang_String_Handler ()
		{
			if (cb_getSequencesForConversation_Ljava_lang_String_ == null)
				cb_getSequencesForConversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSequencesForConversation_Ljava_lang_String_);
			return cb_getSequencesForConversation_Ljava_lang_String_;
		}

		static IntPtr n_GetSequencesForConversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSequencesForConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSequencesForConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='getSequencesForConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSequencesForConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetGetSequencesForConversation_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand GetSequencesForConversation (string p0)
		{
			if (id_getSequencesForConversation_Ljava_lang_String_ == IntPtr.Zero)
				id_getSequencesForConversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSequencesForConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSequencesForConversation_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSequencesForConversation", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isFirstMessageExists;
#pragma warning disable 0169
		static Delegate GetIsFirstMessageExistsHandler ()
		{
			if (cb_isFirstMessageExists == null)
				cb_isFirstMessageExists = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsFirstMessageExists);
			return cb_isFirstMessageExists;
		}

		static IntPtr n_IsFirstMessageExists (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsFirstMessageExists ());
		}
#pragma warning restore 0169

		static IntPtr id_isFirstMessageExists;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='isFirstMessageExists' and count(parameter)=0]"
		[Register ("isFirstMessageExists", "()Lcom/liveperson/infra/database/DataBaseCommand;", "GetIsFirstMessageExistsHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand IsFirstMessageExists ()
		{
			if (id_isFirstMessageExists == IntPtr.Zero)
				id_isFirstMessageExists = JNIEnv.GetMethodID (class_ref, "isFirstMessageExists", "()Lcom/liveperson/infra/database/DataBaseCommand;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isFirstMessageExists), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFirstMessageExists", "()Lcom/liveperson/infra/database/DataBaseCommand;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadMessages (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='loadMessages' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.model.AmsMessages.MessagesSortedBy'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("loadMessages", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;IJJ)Lcom/liveperson/infra/database/DataBaseCommand;", "GetLoadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand LoadMessages (global::Com.Liveperson.Messaging.Model.AmsMessages.MessagesSortedBy p0, string p1, int p2, long p3, long p4)
		{
			if (id_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ == IntPtr.Zero)
				id_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ = JNIEnv.GetMethodID (class_ref, "loadMessages", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;IJJ)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadMessages_Lcom_liveperson_messaging_model_AmsMessages_MessagesSortedBy_Ljava_lang_String_IJJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadMessages", "(Lcom/liveperson/messaging/model/AmsMessages$MessagesSortedBy;Ljava/lang/String;IJJ)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadMessagingUserProfile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadMessagingUserProfile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='loadMessagingUserProfile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadMessagingUserProfile", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingUserProfile;", "GetLoadMessagingUserProfile_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Model.MessagingUserProfile LoadMessagingUserProfile (string p0)
		{
			if (id_loadMessagingUserProfile_Ljava_lang_String_ == IntPtr.Zero)
				id_loadMessagingUserProfile_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadMessagingUserProfile", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingUserProfile;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Model.MessagingUserProfile __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadMessagingUserProfile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingUserProfile> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadMessagingUserProfile", "(Ljava/lang/String;)Lcom/liveperson/messaging/model/MessagingUserProfile;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_refreshCursor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRefreshCursor_Ljava_lang_String_Handler ()
		{
			if (cb_refreshCursor_Ljava_lang_String_ == null)
				cb_refreshCursor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RefreshCursor_Ljava_lang_String_);
			return cb_refreshCursor_Ljava_lang_String_;
		}

		static void n_RefreshCursor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RefreshCursor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_refreshCursor_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='refreshCursor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("refreshCursor", "(Ljava/lang/String;)V", "GetRefreshCursor_Ljava_lang_String_Handler")]
		public virtual unsafe void RefreshCursor (string p0)
		{
			if (id_refreshCursor_Ljava_lang_String_ == IntPtr.Zero)
				id_refreshCursor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "refreshCursor", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshCursor_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshCursor", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOnUpdateListener ();
		}
#pragma warning restore 0169

		static IntPtr id_removeOnUpdateListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='removeOnUpdateListener' and count(parameter)=0]"
		[Register ("removeOnUpdateListener", "()V", "GetRemoveOnUpdateListenerHandler")]
		public virtual unsafe void RemoveOnUpdateListener ()
		{
			if (id_removeOnUpdateListener == IntPtr.Zero)
				id_removeOnUpdateListener = JNIEnv.GetMethodID (class_ref, "removeOnUpdateListener", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeOnUpdateListener);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeOnUpdateListener", "()V"));
			} finally {
			}
		}

		static Delegate cb_resendAllPendingMessages_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResendAllPendingMessages_Ljava_lang_String_Handler ()
		{
			if (cb_resendAllPendingMessages_Ljava_lang_String_ == null)
				cb_resendAllPendingMessages_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResendAllPendingMessages_Ljava_lang_String_);
			return cb_resendAllPendingMessages_Ljava_lang_String_;
		}

		static void n_ResendAllPendingMessages_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResendAllPendingMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_resendAllPendingMessages_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='resendAllPendingMessages' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("resendAllPendingMessages", "(Ljava/lang/String;)V", "GetResendAllPendingMessages_Ljava_lang_String_Handler")]
		public virtual unsafe void ResendAllPendingMessages (string p0)
		{
			if (id_resendAllPendingMessages_Ljava_lang_String_ == IntPtr.Zero)
				id_resendAllPendingMessages_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "resendAllPendingMessages", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resendAllPendingMessages_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resendAllPendingMessages", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetQuickRepliesMessageHolder ();
		}
#pragma warning restore 0169

		static IntPtr id_resetQuickRepliesMessageHolder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='resetQuickRepliesMessageHolder' and count(parameter)=0]"
		[Register ("resetQuickRepliesMessageHolder", "()V", "GetResetQuickRepliesMessageHolderHandler")]
		public virtual unsafe void ResetQuickRepliesMessageHolder ()
		{
			if (id_resetQuickRepliesMessageHolder == IntPtr.Zero)
				id_resetQuickRepliesMessageHolder = JNIEnv.GetMethodID (class_ref, "resetQuickRepliesMessageHolder", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetQuickRepliesMessageHolder);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetQuickRepliesMessageHolder", "()V"));
			} finally {
			}
		}

		static Delegate cb_searchMessages_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSearchMessages_Ljava_lang_String_Handler ()
		{
			if (cb_searchMessages_Ljava_lang_String_ == null)
				cb_searchMessages_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SearchMessages_Ljava_lang_String_);
			return cb_searchMessages_Ljava_lang_String_;
		}

		static IntPtr n_SearchMessages_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SearchMessages (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_searchMessages_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='searchMessages' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("searchMessages", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetSearchMessages_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand SearchMessages (string p0)
		{
			if (id_searchMessages_Ljava_lang_String_ == IntPtr.Zero)
				id_searchMessages_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "searchMessages", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_searchMessages_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "searchMessages", "(Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendReadAckOnMessages (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='sendReadAckOnMessages' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendReadAckOnMessages", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SendReadAckOnMessages (string p0, string p1, string p2)
		{
			if (id_sendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendReadAckOnMessages", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendReadAckOnMessages_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendReadAckOnMessages", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_;
#pragma warning disable 0169
		static Delegate GetSetDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_Handler ()
		{
			if (cb_setDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_ == null)
				cb_setDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_);
			return cb_setDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_;
		}

		static void n_SetDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.Form p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Form> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.DeliveryStatus p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDeliveryStatusUpdateCommand (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='setDeliveryStatusUpdateCommand' and count(parameter)=2 and parameter[1][@type='com.liveperson.messaging.model.Form'] and parameter[2][@type='com.liveperson.api.response.types.DeliveryStatus']]"
		[Register ("setDeliveryStatusUpdateCommand", "(Lcom/liveperson/messaging/model/Form;Lcom/liveperson/api/response/types/DeliveryStatus;)V", "GetSetDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_Handler")]
		public virtual unsafe void SetDeliveryStatusUpdateCommand (global::Com.Liveperson.Messaging.Model.Form p0, global::Com.Liveperson.Api.Response.Types.DeliveryStatus p1)
		{
			if (id_setDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_ == IntPtr.Zero)
				id_setDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_ = JNIEnv.GetMethodID (class_ref, "setDeliveryStatusUpdateCommand", "(Lcom/liveperson/messaging/model/Form;Lcom/liveperson/api/response/types/DeliveryStatus;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeliveryStatusUpdateCommand_Lcom_liveperson_messaging_model_Form_Lcom_liveperson_api_response_types_DeliveryStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeliveryStatusUpdateCommand", "(Lcom/liveperson/messaging/model/Form;Lcom/liveperson/api/response/types/DeliveryStatus;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutDown;
#pragma warning disable 0169
		static Delegate GetShutDownHandler ()
		{
			if (cb_shutDown == null)
				cb_shutDown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShutDown);
			return cb_shutDown;
		}

		static void n_ShutDown (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "GetShutDownHandler")]
		public virtual unsafe void ShutDown ()
		{
			if (id_shutDown == IntPtr.Zero)
				id_shutDown = JNIEnv.GetMethodID (class_ref, "shutDown", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutDown", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateAgentDetailsUpdated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateAgentDetailsUpdated' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateAgentDetailsUpdated", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateAgentDetailsUpdated (string p0, string p1)
		{
			if (id_updateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateAgentDetailsUpdated", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateAgentDetailsUpdated_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateAgentDetailsUpdated", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
#pragma warning disable 0169
		static Delegate GetUpdateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler ()
		{
			if (cb_updateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == null)
				cb_updateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_);
			return cb_updateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		}

		static void n_UpdateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateAllMessagesStateByConversationID (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateAllMessagesStateByConversationID' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
		[Register ("updateAllMessagesStateByConversationID", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V", "GetUpdateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler")]
		public virtual unsafe void UpdateAllMessagesStateByConversationID (string p0, string p1, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p2)
		{
			if (id_updateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
				id_updateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetMethodID (class_ref, "updateAllMessagesStateByConversationID", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateAllMessagesStateByConversationID_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateAllMessagesStateByConversationID", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateFetchHistoryEnded_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateFetchHistoryEnded_Ljava_lang_String_Handler ()
		{
			if (cb_updateFetchHistoryEnded_Ljava_lang_String_ == null)
				cb_updateFetchHistoryEnded_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateFetchHistoryEnded_Ljava_lang_String_);
			return cb_updateFetchHistoryEnded_Ljava_lang_String_;
		}

		static void n_UpdateFetchHistoryEnded_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateFetchHistoryEnded (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateFetchHistoryEnded_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateFetchHistoryEnded' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateFetchHistoryEnded", "(Ljava/lang/String;)V", "GetUpdateFetchHistoryEnded_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateFetchHistoryEnded (string p0)
		{
			if (id_updateFetchHistoryEnded_Ljava_lang_String_ == IntPtr.Zero)
				id_updateFetchHistoryEnded_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateFetchHistoryEnded", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateFetchHistoryEnded_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFetchHistoryEnded", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateFetchHistoryEnded_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateFetchHistoryEnded_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateFetchHistoryEnded_Ljava_lang_String_Z == null)
				cb_updateFetchHistoryEnded_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateFetchHistoryEnded_Ljava_lang_String_Z);
			return cb_updateFetchHistoryEnded_Ljava_lang_String_Z;
		}

		static void n_UpdateFetchHistoryEnded_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateFetchHistoryEnded (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateFetchHistoryEnded_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateFetchHistoryEnded' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateFetchHistoryEnded", "(Ljava/lang/String;Z)V", "GetUpdateFetchHistoryEnded_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateFetchHistoryEnded (string p0, bool p1)
		{
			if (id_updateFetchHistoryEnded_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateFetchHistoryEnded_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateFetchHistoryEnded", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateFetchHistoryEnded_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFetchHistoryEnded", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateFileMessageByRowId_JJ;
#pragma warning disable 0169
		static Delegate GetUpdateFileMessageByRowId_JJHandler ()
		{
			if (cb_updateFileMessageByRowId_JJ == null)
				cb_updateFileMessageByRowId_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr>) n_UpdateFileMessageByRowId_JJ);
			return cb_updateFileMessageByRowId_JJ;
		}

		static IntPtr n_UpdateFileMessageByRowId_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UpdateFileMessageByRowId (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_updateFileMessageByRowId_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateFileMessageByRowId' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("updateFileMessageByRowId", "(JJ)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateFileMessageByRowId_JJHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateFileMessageByRowId (long p0, long p1)
		{
			if (id_updateFileMessageByRowId_JJ == IntPtr.Zero)
				id_updateFileMessageByRowId_JJ = JNIEnv.GetMethodID (class_ref, "updateFileMessageByRowId", "(JJ)Lcom/liveperson/infra/database/DataBaseCommand;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateFileMessageByRowId_JJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateFileMessageByRowId", "(JJ)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_updateHandledExConversation_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateHandledExConversation_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateHandledExConversation_Ljava_lang_String_Z == null)
				cb_updateHandledExConversation_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateHandledExConversation_Ljava_lang_String_Z);
			return cb_updateHandledExConversation_Ljava_lang_String_Z;
		}

		static void n_UpdateHandledExConversation_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateHandledExConversation (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateHandledExConversation_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateHandledExConversation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateHandledExConversation", "(Ljava/lang/String;Z)V", "GetUpdateHandledExConversation_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateHandledExConversation (string p0, bool p1)
		{
			if (id_updateHandledExConversation_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateHandledExConversation_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateHandledExConversation", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateHandledExConversation_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateHandledExConversation", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateMessageConversationServerIdAndTime_JLjava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetUpdateMessageConversationServerIdAndTime_JLjava_lang_String_JHandler ()
		{
			if (cb_updateMessageConversationServerIdAndTime_JLjava_lang_String_J == null)
				cb_updateMessageConversationServerIdAndTime_JLjava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, long, IntPtr>) n_UpdateMessageConversationServerIdAndTime_JLjava_lang_String_J);
			return cb_updateMessageConversationServerIdAndTime_JLjava_lang_String_J;
		}

		static IntPtr n_UpdateMessageConversationServerIdAndTime_JLjava_lang_String_J (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, long p2)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateMessageConversationServerIdAndTime (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageConversationServerIdAndTime_JLjava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateMessageConversationServerIdAndTime' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("updateMessageConversationServerIdAndTime", "(JLjava/lang/String;J)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateMessageConversationServerIdAndTime_JLjava_lang_String_JHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateMessageConversationServerIdAndTime (long p0, string p1, long p2)
		{
			if (id_updateMessageConversationServerIdAndTime_JLjava_lang_String_J == IntPtr.Zero)
				id_updateMessageConversationServerIdAndTime_JLjava_lang_String_J = JNIEnv.GetMethodID (class_ref, "updateMessageConversationServerIdAndTime", "(JLjava/lang/String;J)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageConversationServerIdAndTime_JLjava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageConversationServerIdAndTime", "(JLjava/lang/String;J)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateMessageFileChanged_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetUpdateMessageFileChanged_Ljava_lang_String_JHandler ()
		{
			if (cb_updateMessageFileChanged_Ljava_lang_String_J == null)
				cb_updateMessageFileChanged_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_UpdateMessageFileChanged_Ljava_lang_String_J);
			return cb_updateMessageFileChanged_Ljava_lang_String_J;
		}

		static void n_UpdateMessageFileChanged_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageFileChanged (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageFileChanged_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateMessageFileChanged' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("updateMessageFileChanged", "(Ljava/lang/String;J)V", "GetUpdateMessageFileChanged_Ljava_lang_String_JHandler")]
		public virtual unsafe void UpdateMessageFileChanged (string p0, long p1)
		{
			if (id_updateMessageFileChanged_Ljava_lang_String_J == IntPtr.Zero)
				id_updateMessageFileChanged_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "updateMessageFileChanged", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageFileChanged_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageFileChanged", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_;
#pragma warning disable 0169
		static Delegate GetUpdateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Handler ()
		{
			if (cb_updateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_ == null)
				cb_updateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_);
			return cb_updateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_;
		}

		static IntPtr n_UpdateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateMessageOnRetry (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateMessageOnRetry' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage']]"
		[Register ("updateMessageOnRetry", "(Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateMessageOnRetry (string p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage p1)
		{
			if (id_updateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_ == IntPtr.Zero)
				id_updateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_ = JNIEnv.GetMethodID (class_ref, "updateMessageOnRetry", "(Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageOnRetry_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageOnRetry", "(Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_;
#pragma warning disable 0169
		static Delegate GetUpdateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_Handler ()
		{
			if (cb_updateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_ == null)
				cb_updateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_);
			return cb_updateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_;
		}

		static void n_UpdateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Com.Liveperson.Api.Response.Types.DeliveryStatus p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.DeliveryStatus> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageReceivedState (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateMessageReceivedState' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int[]'] and parameter[4][@type='com.liveperson.api.response.types.DeliveryStatus']]"
		[Register ("updateMessageReceivedState", "(Ljava/lang/String;Ljava/lang/String;[ILcom/liveperson/api/response/types/DeliveryStatus;)V", "GetUpdateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_Handler")]
		public virtual unsafe void UpdateMessageReceivedState (string p0, string p1, int[] p2, global::Com.Liveperson.Api.Response.Types.DeliveryStatus p3)
		{
			if (id_updateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_ == IntPtr.Zero)
				id_updateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_ = JNIEnv.GetMethodID (class_ref, "updateMessageReceivedState", "(Ljava/lang/String;Ljava/lang/String;[ILcom/liveperson/api/response/types/DeliveryStatus;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageReceivedState_Ljava_lang_String_Ljava_lang_String_arrayILcom_liveperson_api_response_types_DeliveryStatus_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageReceivedState", "(Ljava/lang/String;Ljava/lang/String;[ILcom/liveperson/api/response/types/DeliveryStatus;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_updateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
#pragma warning disable 0169
		static Delegate GetUpdateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler ()
		{
			if (cb_updateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == null)
				cb_updateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_);
			return cb_updateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		}

		static void n_UpdateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageState (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateMessageState' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
		[Register ("updateMessageState", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V", "GetUpdateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler")]
		public virtual unsafe void UpdateMessageState (string p0, string p1, string p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3)
		{
			if (id_updateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
				id_updateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetMethodID (class_ref, "updateMessageState", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageState_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageState", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_updateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
#pragma warning disable 0169
		static Delegate GetUpdateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler ()
		{
			if (cb_updateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == null)
				cb_updateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UpdateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_);
			return cb_updateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		}

		static void n_UpdateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateMessageState' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
		[Register ("updateMessageState", "(JLcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V", "GetUpdateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler")]
		public virtual unsafe void UpdateMessageState (long p0, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p1)
		{
			if (id_updateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
				id_updateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetMethodID (class_ref, "updateMessageState", "(JLcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageState_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageState", "(JLcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UpdateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateMessagesConversationServerID (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateMessagesConversationServerID' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateMessagesConversationServerID", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateMessagesConversationServerID (string p0, string p1)
		{
			if (id_updateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateMessagesConversationServerID", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateMessagesConversationServerID_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessagesConversationServerID", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
#pragma warning disable 0169
		static Delegate GetUpdateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler ()
		{
			if (cb_updateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == null)
				cb_updateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_);
			return cb_updateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		}

		static void n_UpdateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessagesState (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateMessagesState' and count(parameter)=4 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
		[Register ("updateMessagesState", "(Ljava/util/ArrayList;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V", "GetUpdateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler")]
		public virtual unsafe void UpdateMessagesState (global::System.Collections.Generic.IList<string> p0, string p1, string p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3)
		{
			if (id_updateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
				id_updateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetMethodID (class_ref, "updateMessagesState", "(Ljava/util/ArrayList;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessagesState_Ljava_util_ArrayList_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessagesState", "(Ljava/util/ArrayList;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_updateOnCommand_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateOnCommand_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateOnCommand_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateOnCommand_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateOnCommand_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateOnCommand_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UpdateOnCommand_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateOnCommand (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateOnCommand_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateOnCommand' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateOnCommand", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetUpdateOnCommand_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand UpdateOnCommand (string p0, string p1)
		{
			if (id_updateOnCommand_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateOnCommand_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateOnCommand", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateOnCommand_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateOnCommand", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetUpdateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler ()
		{
			if (cb_updateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == null)
				cb_updateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_UpdateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J);
			return cb_updateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		}

		static void n_UpdateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3)
		{
			global::Com.Liveperson.Messaging.Model.AmsMessages __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.AmsMessages> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateOnMessageAck (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='AmsMessages']/method[@name='updateOnMessageAck' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long']]"
		[Register ("updateOnMessageAck", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "GetUpdateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JHandler")]
		public virtual unsafe void UpdateOnMessageAck (string p0, string p1, string p2, long p3)
		{
			if (id_updateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J == IntPtr.Zero)
				id_updateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "updateOnMessageAck", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateOnMessageAck_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateOnMessageAck", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
