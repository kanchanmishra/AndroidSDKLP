using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/DatabaseManager", DoNotGenerateAcw=true)]
	public partial class DatabaseManager : global::Java.Lang.Object, global::Com.Liveperson.Infra.IClearable, global::Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDown {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager.DatabaseHelper']"
		[global::Android.Runtime.Register ("com/liveperson/infra/database/DatabaseManager$DatabaseHelper", DoNotGenerateAcw=true)]
		public partial class DatabaseHelper : global::Android.Database.Sqlite.SQLiteOpenHelper {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/database/DatabaseManager$DatabaseHelper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DatabaseHelper); }
			}

			protected DatabaseHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
#pragma warning disable 0169
			static Delegate GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler ()
			{
				if (cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == null)
					cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_);
				return cb_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			}

			static void n_OnCreate_Landroid_database_sqlite_SQLiteDatabase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Database.DatabaseManager.DatabaseHelper __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager.DatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCreate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCreate_Landroid_database_sqlite_SQLiteDatabase_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager.DatabaseHelper']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.database.sqlite.SQLiteDatabase']]"
			[Register ("onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V", "GetOnCreate_Landroid_database_sqlite_SQLiteDatabase_Handler")]
			public override unsafe void OnCreate (global::Android.Database.Sqlite.SQLiteDatabase p0)
			{
				if (id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ == IntPtr.Zero)
					id_onCreate_Landroid_database_sqlite_SQLiteDatabase_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_database_sqlite_SQLiteDatabase_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/database/sqlite/SQLiteDatabase;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
#pragma warning disable 0169
			static Delegate GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler ()
			{
				if (cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == null)
					cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II);
				return cb_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
			}

			static void n_OnUpgrade_Landroid_database_sqlite_SQLiteDatabase_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
			{
				global::Com.Liveperson.Infra.Database.DatabaseManager.DatabaseHelper __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager.DatabaseHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpgrade (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager.DatabaseHelper']/method[@name='onUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "GetOnUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler")]
			public override unsafe void OnUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
			{
				if (id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
					id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/DatabaseManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DatabaseManager); }
		}

		protected DatabaseManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBrandStructure;
#pragma warning disable 0169
		static Delegate GetGetBrandStructureHandler ()
		{
			if (cb_getBrandStructure == null)
				cb_getBrandStructure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBrandStructure);
			return cb_getBrandStructure;
		}

		static IntPtr n_GetBrandStructure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.DatabaseManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BrandStructure);
		}
#pragma warning restore 0169

		static IntPtr id_getBrandStructure;
		public virtual unsafe global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable BrandStructure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']/method[@name='getBrandStructure' and count(parameter)=0]"
			[Register ("getBrandStructure", "()Lcom/liveperson/infra/database/tables/BrandProfileTable;", "GetGetBrandStructureHandler")]
			get {
				if (id_getBrandStructure == IntPtr.Zero)
					id_getBrandStructure = JNIEnv.GetMethodID (class_ref, "getBrandStructure", "()Lcom/liveperson/infra/database/tables/BrandProfileTable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandStructure), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBrandStructure", "()Lcom/liveperson/infra/database/tables/BrandProfileTable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationsTable;
#pragma warning disable 0169
		static Delegate GetGetConversationsTableHandler ()
		{
			if (cb_getConversationsTable == null)
				cb_getConversationsTable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationsTable);
			return cb_getConversationsTable;
		}

		static IntPtr n_GetConversationsTable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.DatabaseManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConversationsTable);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationsTable;
		public virtual unsafe global::Com.Liveperson.Infra.Database.Tables.ConversationsTable ConversationsTable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']/method[@name='getConversationsTable' and count(parameter)=0]"
			[Register ("getConversationsTable", "()Lcom/liveperson/infra/database/tables/ConversationsTable;", "GetGetConversationsTableHandler")]
			get {
				if (id_getConversationsTable == IntPtr.Zero)
					id_getConversationsTable = JNIEnv.GetMethodID (class_ref, "getConversationsTable", "()Lcom/liveperson/infra/database/tables/ConversationsTable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.ConversationsTable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationsTable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.ConversationsTable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationsTable", "()Lcom/liveperson/infra/database/tables/ConversationsTable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Liveperson.Infra.Database.DatabaseManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/liveperson/infra/database/DatabaseManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/liveperson/infra/database/DatabaseManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessagesTable;
#pragma warning disable 0169
		static Delegate GetGetMessagesTableHandler ()
		{
			if (cb_getMessagesTable == null)
				cb_getMessagesTable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessagesTable);
			return cb_getMessagesTable;
		}

		static IntPtr n_GetMessagesTable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.DatabaseManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessagesTable);
		}
#pragma warning restore 0169

		static IntPtr id_getMessagesTable;
		public virtual unsafe global::Com.Liveperson.Infra.Database.Tables.messagesTable MessagesTable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']/method[@name='getMessagesTable' and count(parameter)=0]"
			[Register ("getMessagesTable", "()Lcom/liveperson/infra/database/tables/MessagesTable;", "GetGetMessagesTableHandler")]
			get {
				if (id_getMessagesTable == IntPtr.Zero)
					id_getMessagesTable = JNIEnv.GetMethodID (class_ref, "getMessagesTable", "()Lcom/liveperson/infra/database/tables/MessagesTable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.messagesTable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessagesTable), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.messagesTable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessagesTable", "()Lcom/liveperson/infra/database/tables/MessagesTable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUsersStructure;
#pragma warning disable 0169
		static Delegate GetGetUsersStructureHandler ()
		{
			if (cb_getUsersStructure == null)
				cb_getUsersStructure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsersStructure);
			return cb_getUsersStructure;
		}

		static IntPtr n_GetUsersStructure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.DatabaseManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UsersStructure);
		}
#pragma warning restore 0169

		static IntPtr id_getUsersStructure;
		public virtual unsafe global::Com.Liveperson.Infra.Database.Tables.usersTable UsersStructure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']/method[@name='getUsersStructure' and count(parameter)=0]"
			[Register ("getUsersStructure", "()Lcom/liveperson/infra/database/tables/UsersTable;", "GetGetUsersStructureHandler")]
			get {
				if (id_getUsersStructure == IntPtr.Zero)
					id_getUsersStructure = JNIEnv.GetMethodID (class_ref, "getUsersStructure", "()Lcom/liveperson/infra/database/tables/UsersTable;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.usersTable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsersStructure), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.usersTable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsersStructure", "()Lcom/liveperson/infra/database/tables/UsersTable;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Liveperson.Infra.Database.DatabaseManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']/method[@name='clear' and count(parameter)=0]"
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

		static Delegate cb_registerTable_Lcom_liveperson_infra_database_tables_BaseTable_;
#pragma warning disable 0169
		static Delegate GetRegisterTable_Lcom_liveperson_infra_database_tables_BaseTable_Handler ()
		{
			if (cb_registerTable_Lcom_liveperson_infra_database_tables_BaseTable_ == null)
				cb_registerTable_Lcom_liveperson_infra_database_tables_BaseTable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterTable_Lcom_liveperson_infra_database_tables_BaseTable_);
			return cb_registerTable_Lcom_liveperson_infra_database_tables_BaseTable_;
		}

		static void n_RegisterTable_Lcom_liveperson_infra_database_tables_BaseTable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.DatabaseManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Tables.IBaseTable p0 = (global::Com.Liveperson.Infra.Database.Tables.IBaseTable)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.IBaseTable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterTable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerTable_Lcom_liveperson_infra_database_tables_BaseTable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']/method[@name='registerTable' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.tables.BaseTable']]"
		[Register ("registerTable", "(Lcom/liveperson/infra/database/tables/BaseTable;)V", "GetRegisterTable_Lcom_liveperson_infra_database_tables_BaseTable_Handler")]
		public virtual unsafe void RegisterTable (global::Com.Liveperson.Infra.Database.Tables.IBaseTable p0)
		{
			if (id_registerTable_Lcom_liveperson_infra_database_tables_BaseTable_ == IntPtr.Zero)
				id_registerTable_Lcom_liveperson_infra_database_tables_BaseTable_ = JNIEnv.GetMethodID (class_ref, "registerTable", "(Lcom/liveperson/infra/database/tables/BaseTable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerTable_Lcom_liveperson_infra_database_tables_BaseTable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerTable", "(Lcom/liveperson/infra/database/tables/BaseTable;)V"), __args);
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
			global::Com.Liveperson.Infra.Database.DatabaseManager __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DatabaseManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutDown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DatabaseManager']/method[@name='shutDown' and count(parameter)=0]"
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

	}
}
