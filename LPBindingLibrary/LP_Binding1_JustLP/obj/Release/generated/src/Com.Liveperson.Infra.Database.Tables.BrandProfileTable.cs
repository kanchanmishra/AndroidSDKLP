using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database.Tables {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/tables/BrandProfileTable", DoNotGenerateAcw=true)]
	public partial class BrandProfileTable : global::Java.Lang.Object, global::Com.Liveperson.Infra.Database.Tables.IBaseTable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/field[@name='BRAND_TABLE']"
		[Register ("BRAND_TABLE")]
		public const string BrandTable = (string) "brandProfile";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/field[@name='KEY_BIO']"
		[Register ("KEY_BIO")]
		public const string KeyBio = (string) "bio";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/field[@name='KEY_BRAND_ID']"
		[Register ("KEY_BRAND_ID")]
		public const string KeyBrandId = (string) "brandId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/field[@name='KEY_COVER_IMAGE']"
		[Register ("KEY_COVER_IMAGE")]
		public const string KeyCoverImage = (string) "coverImage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/field[@name='KEY_IS_SAVED']"
		[Register ("KEY_IS_SAVED")]
		public const string KeyIsSaved = (string) "isSaved";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/field[@name='KEY_LOGO_IMAGE']"
		[Register ("KEY_LOGO_IMAGE")]
		public const string KeyLogoImage = (string) "logoImage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/field[@name='KEY_NAME']"
		[Register ("KEY_NAME")]
		public const string KeyName = (string) "name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/field[@name='KEY_SKILL']"
		[Register ("KEY_SKILL")]
		public const string KeySkill = (string) "skill";

		public static class InterfaceConsts {

			// The following are fields from: com.liveperson.infra.database.tables.BaseTable

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/interface[@name='BaseTable']/field[@name='KEY_ID']"
			[Register ("KEY_ID")]
			public const string KeyId = (string) "_id";
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/tables/BrandProfileTable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BrandProfileTable); }
		}

		protected BrandProfileTable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/constructor[@name='BrandProfileTable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BrandProfileTable ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BrandProfileTable)) {
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
			global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateSQL);
		}
#pragma warning restore 0169

		static IntPtr id_getCreateSQL;
		public virtual unsafe string CreateSQL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/method[@name='getCreateSQL' and count(parameter)=0]"
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
			global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/method[@name='getName' and count(parameter)=0]"
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
			global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.BrandProfileTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTableUpgrade (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/class[@name='BrandProfileTable']/method[@name='onTableUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
