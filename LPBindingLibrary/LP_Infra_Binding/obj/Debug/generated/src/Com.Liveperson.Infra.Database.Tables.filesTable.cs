using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database.Tables {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/tables/FilesTable", DoNotGenerateAcw=true)]
	public partial class filesTable : global::Java.Lang.Object, global::Com.Liveperson.Infra.Database.Tables.IBaseTable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='FILES_TABLE']"
		[Register ("FILES_TABLE")]
		public const string FilesTable = (string) "files";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='KEY_FILE_TYPE']"
		[Register ("KEY_FILE_TYPE")]
		public const string KeyFileType = (string) "fileType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='KEY_ID_AS_VALUE']"
		[Register ("KEY_ID_AS_VALUE")]
		public const string KeyIdAsValue = (string) "file_row_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='KEY_LOAD_STATUS']"
		[Register ("KEY_LOAD_STATUS")]
		public const string KeyLoadStatus = (string) "loadStatus";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='KEY_LOCAL_URL']"
		[Register ("KEY_LOCAL_URL")]
		public const string KeyLocalUrl = (string) "localUrl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='KEY_LOCAL_URL_UPDATE_TIMESTAMP']"
		[Register ("KEY_LOCAL_URL_UPDATE_TIMESTAMP")]
		public const string KeyLocalUrlUpdateTimestamp = (string) "localUrlTimestamp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='KEY_PREVIEW']"
		[Register ("KEY_PREVIEW")]
		public const string KeyPreview = (string) "preview";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='KEY_RELATED_MESSAGE_ROW_ID']"
		[Register ("KEY_RELATED_MESSAGE_ROW_ID")]
		public const string KeyRelatedMessageRowId = (string) "relatedMessageRowID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/field[@name='KEY_SWIFT_PATH']"
		[Register ("KEY_SWIFT_PATH")]
		public const string KeySwiftPath = (string) "swiftPath";

		public static class InterfaceConsts {

			// The following are fields from: com.liveperson.infra.database.tables.BaseTable

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/interface[@name='BaseTable']/field[@name='KEY_ID']"
			[Register ("KEY_ID")]
			public const string KeyId = (string) "_id";
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']"
		[global::Android.Runtime.Register ("com/liveperson/infra/database/tables/FilesTable$LoadStatus", DoNotGenerateAcw=true)]
		public sealed partial class LoadStatus : global::Java.Lang.Enum {


			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DOWNLOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/field[@name='DOWNLOADING']"
			[Register ("DOWNLOADING")]
			public static global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus Downloading {
				get {
					if (DOWNLOADING_jfieldId == IntPtr.Zero)
						DOWNLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWNLOADING", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWNLOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOT_STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/field[@name='NOT_STARTED']"
			[Register ("NOT_STARTED")]
			public static global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus NotStarted {
				get {
					if (NOT_STARTED_jfieldId == IntPtr.Zero)
						NOT_STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_STARTED", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PREVIEW_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/field[@name='PREVIEW_ERROR']"
			[Register ("PREVIEW_ERROR")]
			public static global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus PreviewError {
				get {
					if (PREVIEW_ERROR_jfieldId == IntPtr.Zero)
						PREVIEW_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREVIEW_ERROR", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREVIEW_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PROCESSING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/field[@name='PROCESSING']"
			[Register ("PROCESSING")]
			public static global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus Processing {
				get {
					if (PROCESSING_jfieldId == IntPtr.Zero)
						PROCESSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PROCESSING", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PROCESSING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUESTING_URL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/field[@name='REQUESTING_URL']"
			[Register ("REQUESTING_URL")]
			public static global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus RequestingUrl {
				get {
					if (REQUESTING_URL_jfieldId == IntPtr.Zero)
						REQUESTING_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUESTING_URL", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUESTING_URL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UPLOADING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/field[@name='UPLOADING']"
			[Register ("UPLOADING")]
			public static global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus Uploading {
				get {
					if (UPLOADING_jfieldId == IntPtr.Zero)
						UPLOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOADING", "Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOADING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/database/tables/FilesTable$LoadStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadStatus); }
			}

			internal LoadStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;", "")]
			public static unsafe global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable.LoadStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;", "")]
			public static unsafe global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/infra/database/tables/FilesTable$LoadStatus;");
				try {
					return (global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Infra.Database.Tables.filesTable.LoadStatus));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/tables/FilesTable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (filesTable); }
		}

		protected filesTable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/constructor[@name='FilesTable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe filesTable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (filesTable)) {
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
			global::Com.Liveperson.Infra.Database.Tables.filesTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateSQL);
		}
#pragma warning restore 0169

		static IntPtr id_getCreateSQL;
		public virtual unsafe string CreateSQL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/method[@name='getCreateSQL' and count(parameter)=0]"
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
			global::Com.Liveperson.Infra.Database.Tables.filesTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/method[@name='getName' and count(parameter)=0]"
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

		static IntPtr id_getProjection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/method[@name='getProjection' and count(parameter)=0]"
		[Register ("getProjection", "()[Ljava/lang/String;", "")]
		public static unsafe string[] GetProjection ()
		{
			if (id_getProjection == IntPtr.Zero)
				id_getProjection = JNIEnv.GetStaticMethodID (class_ref, "getProjection", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProjection), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
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
			global::Com.Liveperson.Infra.Database.Tables.filesTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.filesTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTableUpgrade (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='FilesTable']/method[@name='onTableUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
