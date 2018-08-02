using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/NullMessagesListener", DoNotGenerateAcw=true)]
	public partial class NullMessagesListener : global::Java.Lang.Object, global::Com.Liveperson.Messaging.Model.AmsMessages.IMessagesListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/NullMessagesListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NullMessagesListener); }
		}

		protected NullMessagesListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/constructor[@name='NullMessagesListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NullMessagesListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NullMessagesListener)) {
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.FullMessageRow>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initMessages_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='initMessages' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.liveperson.messaging.model.FullMessageRow&gt;']]"
		[Register ("initMessages", "(Ljava/util/ArrayList;)V", "GetInitMessages_Ljava_util_ArrayList_Handler")]
		public virtual unsafe void InitMessages (global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.FullMessageRow> p0)
		{
			if (id_initMessages_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_initMessages_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "initMessages", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.FullMessageRow>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initMessages_Ljava_util_ArrayList_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initMessages", "(Ljava/util/ArrayList;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnExConversationHandled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onExConversationHandled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='onExConversationHandled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onExConversationHandled", "(Z)V", "GetOnExConversationHandled_ZHandler")]
		public virtual unsafe void OnExConversationHandled (bool p0)
		{
			if (id_onExConversationHandled_Z == IntPtr.Zero)
				id_onExConversationHandled_Z = JNIEnv.GetMethodID (class_ref, "onExConversationHandled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onExConversationHandled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onExConversationHandled", "(Z)V"), __args);
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHistoryFetched ();
		}
#pragma warning restore 0169

		static IntPtr id_onHistoryFetched;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='onHistoryFetched' and count(parameter)=0]"
		[Register ("onHistoryFetched", "()V", "GetOnHistoryFetchedHandler")]
		public virtual unsafe void OnHistoryFetched ()
		{
			if (id_onHistoryFetched == IntPtr.Zero)
				id_onHistoryFetched = JNIEnv.GetMethodID (class_ref, "onHistoryFetched", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHistoryFetched);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHistoryFetched", "()V"));
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnHistoryFetchedFailed ();
		}
#pragma warning restore 0169

		static IntPtr id_onHistoryFetchedFailed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='onHistoryFetchedFailed' and count(parameter)=0]"
		[Register ("onHistoryFetchedFailed", "()V", "GetOnHistoryFetchedFailedHandler")]
		public virtual unsafe void OnHistoryFetchedFailed ()
		{
			if (id_onHistoryFetchedFailed == IntPtr.Zero)
				id_onHistoryFetchedFailed = JNIEnv.GetMethodID (class_ref, "onHistoryFetchedFailed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHistoryFetchedFailed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHistoryFetchedFailed", "()V"));
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.FullMessageRow p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNewMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='onNewMessage' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.FullMessageRow']]"
		[Register ("onNewMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V", "GetOnNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_Handler")]
		public virtual unsafe void OnNewMessage (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
		{
			if (id_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
				id_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetMethodID (class_ref, "onNewMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onNewMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V"), __args);
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnQueryMessagesResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onQueryMessagesResult_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='onQueryMessagesResult' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onQueryMessagesResult", "(JJ)V", "GetOnQueryMessagesResult_JJHandler")]
		public virtual unsafe void OnQueryMessagesResult (long p0, long p1)
		{
			if (id_onQueryMessagesResult_JJ == IntPtr.Zero)
				id_onQueryMessagesResult_JJ = JNIEnv.GetMethodID (class_ref, "onQueryMessagesResult", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onQueryMessagesResult_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onQueryMessagesResult", "(JJ)V"), __args);
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.FullMessageRow p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.FullMessageRow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='onUpdateMessage' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.FullMessageRow']]"
		[Register ("onUpdateMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V", "GetOnUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_Handler")]
		public virtual unsafe void OnUpdateMessage (global::Com.Liveperson.Messaging.Model.FullMessageRow p0)
		{
			if (id_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_ == IntPtr.Zero)
				id_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_ = JNIEnv.GetMethodID (class_ref, "onUpdateMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpdateMessage", "(Lcom/liveperson/messaging/model/FullMessageRow;)V"), __args);
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateMessages (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onUpdateMessages_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='onUpdateMessages' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onUpdateMessages", "(JJ)V", "GetOnUpdateMessages_JJHandler")]
		public virtual unsafe void OnUpdateMessages (long p0, long p1)
		{
			if (id_onUpdateMessages_JJ == IntPtr.Zero)
				id_onUpdateMessages_JJ = JNIEnv.GetMethodID (class_ref, "onUpdateMessages", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateMessages_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpdateMessages", "(JJ)V"), __args);
			} finally {
			}
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
			global::Com.Liveperson.Messaging.Model.NullMessagesListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.NullMessagesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='NullMessagesListener']/method[@name='removeAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeAll", "(Ljava/lang/String;)V", "GetRemoveAll_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveAll (string p0)
		{
			if (id_removeAll_Ljava_lang_String_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
