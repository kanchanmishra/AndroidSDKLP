using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database.Tables {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/tables/ConversationsTable", DoNotGenerateAcw=true)]
	public partial class ConversationsTable : global::Java.Lang.Object, global::Com.Liveperson.Infra.Database.Tables.IBaseTable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='CONVERSATION_TABLE']"
		[Register ("CONVERSATION_TABLE")]
		public const string ConversationTable = (string) "conversations";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_ASSIGNED_AGENT_ID']"
		[Register ("KEY_ASSIGNED_AGENT_ID")]
		public const string KeyAssignedAgentId = (string) "assignedAgentId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_BRAND_ID']"
		[Register ("KEY_BRAND_ID")]
		public const string KeyBrandId = (string) "brandId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_CLOSE_REASON']"
		[Register ("KEY_CLOSE_REASON")]
		public const string KeyCloseReason = (string) "close_reason";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_CLOSE_TIME']"
		[Register ("KEY_CLOSE_TIME")]
		public const string KeyCloseTime = (string) "close_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_CONVERSATION_ID']"
		[Register ("KEY_CONVERSATION_ID")]
		public const string KeyConversationId = (string) "conversationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_LAST_SERVER_SEQUENCE']"
		[Register ("KEY_LAST_SERVER_SEQUENCE")]
		public const string KeyLastServerSequence = (string) "last_server_sequence";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_REQUEST_ID']"
		[Register ("KEY_REQUEST_ID")]
		public const string KeyRequestId = (string) "request_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_SHOWED_CSAT']"
		[Register ("KEY_SHOWED_CSAT")]
		public const string KeyShowedCsat = (string) "showed_csat";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_START_TIME']"
		[Register ("KEY_START_TIME")]
		public const string KeyStartTime = (string) "start_time";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_STATE']"
		[Register ("KEY_STATE")]
		public const string KeyState = (string) "state";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_TARGET_ID']"
		[Register ("KEY_TARGET_ID")]
		public const string KeyTargetId = (string) "targetId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_TTR_TYPE']"
		[Register ("KEY_TTR_TYPE")]
		public const string KeyTtrType = (string) "ttr_type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_UNREAD_MESSAGES']"
		[Register ("KEY_UNREAD_MESSAGES")]
		public const string KeyUnreadMessages = (string) "unread_msg";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/field[@name='KEY_UPDATE_IN_PROGRESS_SEMAPHORE']"
		[Register ("KEY_UPDATE_IN_PROGRESS_SEMAPHORE")]
		public const string KeyUpdateInProgressSemaphore = (string) "updating_in_progress_semaphore";

		public static class InterfaceConsts {

			// The following are fields from: com.liveperson.infra.database.tables.BaseTable

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/interface[@name='BaseTable']/field[@name='KEY_ID']"
			[Register ("KEY_ID")]
			public const string KeyId = (string) "_id";
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/tables/ConversationsTable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationsTable); }
		}

		protected ConversationsTable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/constructor[@name='ConversationsTable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationsTable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationsTable)) {
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

		static Delegate cb_getCreateSQL;
#pragma warning disable 0169
		static Delegate GetGetCreateSQLHandler ()
		{
			if (cb_getCreateSQL == null)
				cb_getCreateSQL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreateSQL);
			return cb_getCreateSQL;
		}

		static IntPtr n_GetCreateSQL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.Tables.ConversationsTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.ConversationsTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateSQL);
		}
#pragma warning restore 0169

		static IntPtr id_getCreateSQL;
		public virtual unsafe string CreateSQL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/method[@name='getCreateSQL' and count(parameter)=0]"
			[Register ("getCreateSQL", "()Ljava/lang/String;", "GetGetCreateSQLHandler")]
			get {
				if (id_getCreateSQL == IntPtr.Zero)
					id_getCreateSQL = JNIEnv.GetMethodID (class_ref, "getCreateSQL", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreateSQL), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreateSQL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.Tables.ConversationsTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.ConversationsTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
#pragma warning disable 0169
		static Delegate GetOnTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler ()
		{
			if (cb_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == null)
				cb_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II);
			return cb_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		}

		static void n_OnTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Liveperson.Infra.Database.Tables.ConversationsTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.ConversationsTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTableUpgrade (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='ConversationsTable']/method[@name='onTableUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onTableUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "GetOnTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler")]
		public virtual unsafe void OnTableUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
		{
			if (id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
				id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onTableUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTableUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V"), __args);
			} finally {
			}
		}

	}
}
