using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/SendFileCommand", DoNotGenerateAcw=true)]
	public abstract partial class SendFileCommand : global::Com.Liveperson.Messaging.Commands.SendMessageCommand {


		static IntPtr mCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/field[@name='mCallback']"
		[Register ("mCallback")]
		protected global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener MCallback {
			get {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/messaging/commands/SendFileCommand$SendFileCommandListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/liveperson/messaging/commands/SendFileCommand$SendFileCommandListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCaption_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/field[@name='mCaption']"
		[Register ("mCaption")]
		protected string MCaption {
			get {
				if (mCaption_jfieldId == IntPtr.Zero)
					mCaption_jfieldId = JNIEnv.GetFieldID (class_ref, "mCaption", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCaption_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCaption_jfieldId == IntPtr.Zero)
					mCaption_jfieldId = JNIEnv.GetFieldID (class_ref, "mCaption", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCaption_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMessageRowId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/field[@name='mMessageRowId']"
		[Register ("mMessageRowId")]
		protected long MMessageRowId {
			get {
				if (mMessageRowId_jfieldId == IntPtr.Zero)
					mMessageRowId_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageRowId", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, mMessageRowId_jfieldId);
			}
			set {
				if (mMessageRowId_jfieldId == IntPtr.Zero)
					mMessageRowId_jfieldId = JNIEnv.GetFieldID (class_ref, "mMessageRowId", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMessageRowId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mPreview_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/field[@name='mPreview']"
		[Register ("mPreview")]
		protected string MPreview {
			get {
				if (mPreview_jfieldId == IntPtr.Zero)
					mPreview_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreview", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPreview_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPreview_jfieldId == IntPtr.Zero)
					mPreview_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreview", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPreview_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging.commands']/interface[@name='SendFileCommand.SendFileCommandListener']"
		[Register ("com/liveperson/messaging/commands/SendFileCommand$SendFileCommandListener", "", "Com.Liveperson.Messaging.Commands.SendFileCommand/ISendFileCommandListenerInvoker")]
		public partial interface ISendFileCommandListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/interface[@name='SendFileCommand.SendFileCommandListener']/method[@name='onFileAddedToDB' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("onFileAddedToDB", "(JJ)V", "GetOnFileAddedToDB_JJHandler:Com.Liveperson.Messaging.Commands.SendFileCommand/ISendFileCommandListenerInvoker, LP_Messaging_Binding")]
			void OnFileAddedToDB (long p0, long p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/interface[@name='SendFileCommand.SendFileCommandListener']/method[@name='onMessageUpdatedInDB' and count(parameter)=0]"
			[Register ("onMessageUpdatedInDB", "()V", "GetOnMessageUpdatedInDBHandler:Com.Liveperson.Messaging.Commands.SendFileCommand/ISendFileCommandListenerInvoker, LP_Messaging_Binding")]
			void OnMessageUpdatedInDB ();

		}

		[global::Android.Runtime.Register ("com/liveperson/messaging/commands/SendFileCommand$SendFileCommandListener", DoNotGenerateAcw=true)]
		internal class ISendFileCommandListenerInvoker : global::Java.Lang.Object, ISendFileCommandListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/commands/SendFileCommand$SendFileCommandListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISendFileCommandListenerInvoker); }
			}

			IntPtr class_ref;

			public static ISendFileCommandListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISendFileCommandListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.commands.SendFileCommand.SendFileCommandListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISendFileCommandListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFileAddedToDB_JJ;
#pragma warning disable 0169
			static Delegate GetOnFileAddedToDB_JJHandler ()
			{
				if (cb_onFileAddedToDB_JJ == null)
					cb_onFileAddedToDB_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_OnFileAddedToDB_JJ);
				return cb_onFileAddedToDB_JJ;
			}

			static void n_OnFileAddedToDB_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
			{
				global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFileAddedToDB (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFileAddedToDB_JJ;
			public unsafe void OnFileAddedToDB (long p0, long p1)
			{
				if (id_onFileAddedToDB_JJ == IntPtr.Zero)
					id_onFileAddedToDB_JJ = JNIEnv.GetMethodID (class_ref, "onFileAddedToDB", "(JJ)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFileAddedToDB_JJ, __args);
			}

			static Delegate cb_onMessageUpdatedInDB;
#pragma warning disable 0169
			static Delegate GetOnMessageUpdatedInDBHandler ()
			{
				if (cb_onMessageUpdatedInDB == null)
					cb_onMessageUpdatedInDB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMessageUpdatedInDB);
				return cb_onMessageUpdatedInDB;
			}

			static void n_OnMessageUpdatedInDB (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageUpdatedInDB ();
			}
#pragma warning restore 0169

			IntPtr id_onMessageUpdatedInDB;
			public unsafe void OnMessageUpdatedInDB ()
			{
				if (id_onMessageUpdatedInDB == IntPtr.Zero)
					id_onMessageUpdatedInDB = JNIEnv.GetMethodID (class_ref, "onMessageUpdatedInDB", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageUpdatedInDB);
			}

		}

		public partial class FileAddedToDBEventArgs : global::System.EventArgs {

			public FileAddedToDBEventArgs (long p0, long p1)
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

		[global::Android.Runtime.Register ("mono/com/liveperson/messaging/commands/SendFileCommand_SendFileCommandListenerImplementor")]
		internal sealed partial class ISendFileCommandListenerImplementor : global::Java.Lang.Object, ISendFileCommandListener {

			object sender;

			public ISendFileCommandListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/messaging/commands/SendFileCommand_SendFileCommandListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FileAddedToDBEventArgs> OnFileAddedToDBHandler;
#pragma warning restore 0649

			public void OnFileAddedToDB (long p0, long p1)
			{
				var __h = OnFileAddedToDBHandler;
				if (__h != null)
					__h (sender, new FileAddedToDBEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler OnMessageUpdatedInDBHandler;
#pragma warning restore 0649

			public void OnMessageUpdatedInDB ()
			{
				var __h = OnMessageUpdatedInDBHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ISendFileCommandListenerImplementor value)
			{
				return value.OnFileAddedToDBHandler == null && value.OnMessageUpdatedInDBHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/SendFileCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendFileCommand); }
		}

		protected SendFileCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/constructor[@name='SendFileCommand' and count(parameter)=8 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", "")]
		public unsafe SendFileCommand (global::Com.Liveperson.Messaging.Messaging p0, string p1, string p2, string p3, string p4, string p5, string p6, global::Com.Liveperson.Infra.Utils.MaskedMessage p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				__args [7] = new JValue (p7);
				if (((object) this).GetType () != typeof (SendFileCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/utils/MaskedMessage;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_utils_MaskedMessage_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_getMessageTime;
#pragma warning disable 0169
		static Delegate GetGetMessageTimeHandler ()
		{
			if (cb_getMessageTime == null)
				cb_getMessageTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMessageTime);
			return cb_getMessageTime;
		}

		static long n_GetMessageTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.SendFileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageTime;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageTime;
		protected virtual unsafe long MessageTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='getMessageTime' and count(parameter)=0]"
			[Register ("getMessageTime", "()J", "GetGetMessageTimeHandler")]
			get {
				if (id_getMessageTime == IntPtr.Zero)
					id_getMessageTime = JNIEnv.GetMethodID (class_ref, "getMessageTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMessageTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_addMessageToDB;
#pragma warning disable 0169
		static Delegate GetAddMessageToDBHandler ()
		{
			if (cb_addMessageToDB == null)
				cb_addMessageToDB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AddMessageToDB);
			return cb_addMessageToDB;
		}

		static void n_AddMessageToDB (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.SendFileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddMessageToDB ();
		}
#pragma warning restore 0169

		static IntPtr id_addMessageToDB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='addMessageToDB' and count(parameter)=0]"
		[Register ("addMessageToDB", "()V", "GetAddMessageToDBHandler")]
		public virtual unsafe void AddMessageToDB ()
		{
			if (id_addMessageToDB == IntPtr.Zero)
				id_addMessageToDB = JNIEnv.GetMethodID (class_ref, "addMessageToDB", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMessageToDB);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMessageToDB", "()V"));
			} finally {
			}
		}

		static Delegate cb_failMessage;
#pragma warning disable 0169
		static Delegate GetFailMessageHandler ()
		{
			if (cb_failMessage == null)
				cb_failMessage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FailMessage);
			return cb_failMessage;
		}

		static void n_FailMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.SendFileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FailMessage ();
		}
#pragma warning restore 0169

		static IntPtr id_failMessage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='failMessage' and count(parameter)=0]"
		[Register ("failMessage", "()V", "GetFailMessageHandler")]
		public virtual unsafe void FailMessage ()
		{
			if (id_failMessage == IntPtr.Zero)
				id_failMessage = JNIEnv.GetMethodID (class_ref, "failMessage", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_failMessage);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "failMessage", "()V"));
			} finally {
			}
		}

		static Delegate cb_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_;
#pragma warning disable 0169
		static Delegate GetGetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_Handler ()
		{
			if (cb_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ == null)
				cb_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_);
			return cb_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_;
		}

		static IntPtr n_GetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Commands.SendFileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.MaskedMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessageType (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='getMessageType' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register ("getMessageType", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "GetGetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_Handler")]
		protected abstract global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType GetMessageType (global::Com.Liveperson.Infra.Utils.MaskedMessage p0);

		static Delegate cb_setCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_Handler ()
		{
			if (cb_setCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_ == null)
				cb_setCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_);
			return cb_setCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_;
		}

		static void n_SetCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Commands.SendFileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener p0 = (global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.commands.SendFileCommand.SendFileCommandListener']]"
		[Register ("setCallback", "(Lcom/liveperson/messaging/commands/SendFileCommand$SendFileCommandListener;)V", "GetSetCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_Handler")]
		public virtual unsafe void SetCallback (global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener p0)
		{
			if (id_setCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_ == IntPtr.Zero)
				id_setCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/messaging/commands/SendFileCommand$SendFileCommandListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_messaging_commands_SendFileCommand_SendFileCommandListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/liveperson/messaging/commands/SendFileCommand$SendFileCommandListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Commands.SendFileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetFileDetails (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='setFileDetails' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setFileDetails", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFileDetails (string p0, string p1, string p2)
		{
			if (id_setFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFileDetails", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFileDetails_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFileDetails", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_;
#pragma warning disable 0169
		static Delegate GetSetSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_Handler ()
		{
			if (cb_setSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_ == null)
				cb_setSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_);
			return cb_setSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_;
		}

		static void n_SetSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Commands.SendFileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Network.Http.RestRequestParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSendViaRest (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='setSendViaRest' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.liveperson.messaging.network.http.RestRequestParams']]"
		[Register ("setSendViaRest", "(ZLcom/liveperson/messaging/network/http/RestRequestParams;)V", "GetSetSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_Handler")]
		public virtual unsafe void SetSendViaRest (bool p0, global::Com.Liveperson.Messaging.Network.Http.RestRequestParams p1)
		{
			if (id_setSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_ == IntPtr.Zero)
				id_setSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_ = JNIEnv.GetMethodID (class_ref, "setSendViaRest", "(ZLcom/liveperson/messaging/network/http/RestRequestParams;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSendViaRest_ZLcom_liveperson_messaging_network_http_RestRequestParams_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSendViaRest", "(ZLcom/liveperson/messaging/network/http/RestRequestParams;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateMessageConversationID;
#pragma warning disable 0169
		static Delegate GetUpdateMessageConversationIDHandler ()
		{
			if (cb_updateMessageConversationID == null)
				cb_updateMessageConversationID = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateMessageConversationID);
			return cb_updateMessageConversationID;
		}

		static void n_UpdateMessageConversationID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.SendFileCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.SendFileCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageConversationID ();
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageConversationID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='updateMessageConversationID' and count(parameter)=0]"
		[Register ("updateMessageConversationID", "()V", "GetUpdateMessageConversationIDHandler")]
		public virtual unsafe void UpdateMessageConversationID ()
		{
			if (id_updateMessageConversationID == IntPtr.Zero)
				id_updateMessageConversationID = JNIEnv.GetMethodID (class_ref, "updateMessageConversationID", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageConversationID);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageConversationID", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener"
		public event EventHandler<global::Com.Liveperson.Messaging.Commands.SendFileCommand.FileAddedToDBEventArgs> FileAddedToDB {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener, global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListenerImplementor>(
						ref weak_implementor_SetCallback,
						__CreateISendFileCommandListenerImplementor,
						SetCallback,
						__h => __h.OnFileAddedToDBHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener, global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListenerImplementor>(
						ref weak_implementor_SetCallback,
						global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListenerImplementor.__IsEmpty,
						__v => SetCallback (null),
						__h => __h.OnFileAddedToDBHandler -= value);
			}
		}

		public event EventHandler MessageUpdatedInDB {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener, global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListenerImplementor>(
						ref weak_implementor_SetCallback,
						__CreateISendFileCommandListenerImplementor,
						SetCallback,
						__h => __h.OnMessageUpdatedInDBHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListener, global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListenerImplementor>(
						ref weak_implementor_SetCallback,
						global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListenerImplementor.__IsEmpty,
						__v => SetCallback (null),
						__h => __h.OnMessageUpdatedInDBHandler -= value);
			}
		}

		WeakReference weak_implementor_SetCallback;

		global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListenerImplementor __CreateISendFileCommandListenerImplementor ()
		{
			return new global::Com.Liveperson.Messaging.Commands.SendFileCommand.ISendFileCommandListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/SendFileCommand", DoNotGenerateAcw=true)]
	internal partial class SendFileCommandInvoker : SendFileCommand {

		public SendFileCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SendFileCommandInvoker); }
		}

		static IntPtr id_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands']/class[@name='SendFileCommand']/method[@name='getMessageType' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.utils.MaskedMessage']]"
		[Register ("getMessageType", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;", "GetGetMessageType_Lcom_liveperson_infra_utils_MaskedMessage_Handler")]
		protected override unsafe global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType GetMessageType (global::Com.Liveperson.Infra.Utils.MaskedMessage p0)
		{
			if (id_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ == IntPtr.Zero)
				id_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_ = JNIEnv.GetMethodID (class_ref, "getMessageType", "(Lcom/liveperson/infra/utils/MaskedMessage;)Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageType_Lcom_liveperson_infra_utils_MaskedMessage_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
