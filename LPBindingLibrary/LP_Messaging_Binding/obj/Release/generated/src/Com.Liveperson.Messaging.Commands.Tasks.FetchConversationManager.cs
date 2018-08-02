using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Commands.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/FetchConversationManager", DoNotGenerateAcw=true)]
	public partial class FetchConversationManager : global::Java.Lang.Object {


		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/field[@name='mController']"
		[Register ("mController")]
		protected global::Com.Liveperson.Messaging.Messaging MController {
			get {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConversationUtils_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/field[@name='mConversationUtils']"
		[Register ("mConversationUtils")]
		protected global::Com.Liveperson.Messaging.Model.ConversationUtils MConversationUtils {
			get {
				if (mConversationUtils_jfieldId == IntPtr.Zero)
					mConversationUtils_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationUtils", "Lcom/liveperson/messaging/model/ConversationUtils;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConversationUtils_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.ConversationUtils> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConversationUtils_jfieldId == IntPtr.Zero)
					mConversationUtils_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationUtils", "Lcom/liveperson/messaging/model/ConversationUtils;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConversationUtils_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr numConversationToUpdateUI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/field[@name='numConversationToUpdateUI']"
		[Register ("numConversationToUpdateUI")]
		protected int NumConversationToUpdateUI {
			get {
				if (numConversationToUpdateUI_jfieldId == IntPtr.Zero)
					numConversationToUpdateUI_jfieldId = JNIEnv.GetFieldID (class_ref, "numConversationToUpdateUI", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, numConversationToUpdateUI_jfieldId);
			}
			set {
				if (numConversationToUpdateUI_jfieldId == IntPtr.Zero)
					numConversationToUpdateUI_jfieldId = JNIEnv.GetFieldID (class_ref, "numConversationToUpdateUI", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, numConversationToUpdateUI_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr usersUpdating_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/field[@name='usersUpdating']"
		[Register ("usersUpdating")]
		protected global::Java.Util.HashSet UsersUpdating {
			get {
				if (usersUpdating_jfieldId == IntPtr.Zero)
					usersUpdating_jfieldId = JNIEnv.GetFieldID (class_ref, "usersUpdating", "Ljava/util/HashSet;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, usersUpdating_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (usersUpdating_jfieldId == IntPtr.Zero)
					usersUpdating_jfieldId = JNIEnv.GetFieldID (class_ref, "usersUpdating", "Ljava/util/HashSet;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, usersUpdating_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager.DATA_SOURCE']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE", DoNotGenerateAcw=true)]
		public sealed partial class DATA_SOURCE : global::Java.Lang.Enum {


			static IntPtr INCA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager.DATA_SOURCE']/field[@name='INCA']"
			[Register ("INCA")]
			public static global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE Inca {
				get {
					if (INCA_jfieldId == IntPtr.Zero)
						INCA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INCA", "Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INCA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager.DATA_SOURCE']/field[@name='UMS']"
			[Register ("UMS")]
			public static global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE Ums {
				get {
					if (UMS_jfieldId == IntPtr.Zero)
						UMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UMS", "Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DATA_SOURCE); }
			}

			internal DATA_SOURCE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager.DATA_SOURCE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager.DATA_SOURCE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/commands/tasks/FetchConversationManager$DATA_SOURCE;");
				try {
					return (global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager.DATA_SOURCE));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager.QueryRequestMessage']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/commands/tasks/FetchConversationManager$QueryRequestMessage", DoNotGenerateAcw=true)]
		public partial class QueryRequestMessage : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/FetchConversationManager$QueryRequestMessage", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (QueryRequestMessage); }
			}

			protected QueryRequestMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_IILcom_liveperson_messaging_model_ConversationData_Z;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager.QueryRequestMessage']/constructor[@name='FetchConversationManager.QueryRequestMessage' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.commands.tasks.FetchConversationManager'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.liveperson.messaging.model.ConversationData'] and parameter[5][@type='boolean']]"
			[Register (".ctor", "(Lcom/liveperson/messaging/commands/tasks/FetchConversationManager;IILcom/liveperson/messaging/model/ConversationData;Z)V", "")]
			public unsafe QueryRequestMessage (global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager __self, int p1, int p2, global::Com.Liveperson.Messaging.Model.ConversationData p3, bool p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					if (((object) this).GetType () != typeof (QueryRequestMessage)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IILcom/liveperson/messaging/model/ConversationData;Z)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IILcom/liveperson/messaging/model/ConversationData;Z)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_IILcom_liveperson_messaging_model_ConversationData_Z == IntPtr.Zero)
						id_ctor_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_IILcom_liveperson_messaging_model_ConversationData_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/commands/tasks/FetchConversationManager;IILcom/liveperson/messaging/model/ConversationData;Z)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_IILcom_liveperson_messaging_model_ConversationData_Z, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_commands_tasks_FetchConversationManager_IILcom_liveperson_messaging_model_ConversationData_Z, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/commands/tasks/FetchConversationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FetchConversationManager); }
		}

		protected FetchConversationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/constructor[@name='FetchConversationManager' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.Messaging']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;)V", "")]
		public unsafe FetchConversationManager (global::Com.Liveperson.Messaging.Messaging p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FetchConversationManager)) {
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

		static Delegate cb_fetchConversation_Lcom_liveperson_messaging_model_Conversation_;
#pragma warning disable 0169
		static Delegate GetFetchConversation_Lcom_liveperson_messaging_model_Conversation_Handler ()
		{
			if (cb_fetchConversation_Lcom_liveperson_messaging_model_Conversation_ == null)
				cb_fetchConversation_Lcom_liveperson_messaging_model_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FetchConversation_Lcom_liveperson_messaging_model_Conversation_);
			return cb_fetchConversation_Lcom_liveperson_messaging_model_Conversation_;
		}

		static void n_FetchConversation_Lcom_liveperson_messaging_model_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FetchConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fetchConversation_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/method[@name='fetchConversation' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.Conversation']]"
		[Register ("fetchConversation", "(Lcom/liveperson/messaging/model/Conversation;)V", "GetFetchConversation_Lcom_liveperson_messaging_model_Conversation_Handler")]
		public virtual unsafe void FetchConversation (global::Com.Liveperson.Messaging.Model.Conversation p0)
		{
			if (id_fetchConversation_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
				id_fetchConversation_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetMethodID (class_ref, "fetchConversation", "(Lcom/liveperson/messaging/model/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchConversation_Lcom_liveperson_messaging_model_Conversation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetchConversation", "(Lcom/liveperson/messaging/model/Conversation;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_fetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetFetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_fetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ == null)
				cb_fetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_);
			return cb_fetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_;
		}

		static void n_FetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.FetchConversationsFirstTime (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_fetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/method[@name='fetchConversationsFirstTime' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.liveperson.messaging.model.ConversationData&gt;'] and parameter[3][@type='java.util.List&lt;com.liveperson.messaging.model.ConversationData&gt;']]"
		[Register ("fetchConversationsFirstTime", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V", "GetFetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe void FetchConversationsFirstTime (string p0, global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.ConversationData> p1, global::System.Collections.Generic.IList<global::Com.Liveperson.Messaging.Model.ConversationData> p2)
		{
			if (id_fetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_fetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "fetchConversationsFirstTime", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Liveperson.Messaging.Model.ConversationData>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetchConversationsFirstTime_Ljava_lang_String_Ljava_util_List_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetchConversationsFirstTime", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		protected virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_refreshConversation_Lcom_liveperson_messaging_model_Conversation_;
#pragma warning disable 0169
		static Delegate GetRefreshConversation_Lcom_liveperson_messaging_model_Conversation_Handler ()
		{
			if (cb_refreshConversation_Lcom_liveperson_messaging_model_Conversation_ == null)
				cb_refreshConversation_Lcom_liveperson_messaging_model_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RefreshConversation_Lcom_liveperson_messaging_model_Conversation_);
			return cb_refreshConversation_Lcom_liveperson_messaging_model_Conversation_;
		}

		static void n_RefreshConversation_Lcom_liveperson_messaging_model_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Commands.Tasks.FetchConversationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RefreshConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_refreshConversation_Lcom_liveperson_messaging_model_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.commands.tasks']/class[@name='FetchConversationManager']/method[@name='refreshConversation' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.model.Conversation']]"
		[Register ("refreshConversation", "(Lcom/liveperson/messaging/model/Conversation;)V", "GetRefreshConversation_Lcom_liveperson_messaging_model_Conversation_Handler")]
		public virtual unsafe void RefreshConversation (global::Com.Liveperson.Messaging.Model.Conversation p0)
		{
			if (id_refreshConversation_Lcom_liveperson_messaging_model_Conversation_ == IntPtr.Zero)
				id_refreshConversation_Lcom_liveperson_messaging_model_Conversation_ = JNIEnv.GetMethodID (class_ref, "refreshConversation", "(Lcom/liveperson/messaging/model/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshConversation_Lcom_liveperson_messaging_model_Conversation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshConversation", "(Lcom/liveperson/messaging/model/Conversation;)V"), __args);
			} finally {
			}
		}

	}
}
