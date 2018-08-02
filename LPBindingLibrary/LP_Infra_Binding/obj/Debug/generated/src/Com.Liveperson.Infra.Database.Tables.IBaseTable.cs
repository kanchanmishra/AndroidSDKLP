using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database.Tables {

	[Register ("com/liveperson/infra/database/tables/BaseTable", DoNotGenerateAcw=true)]
	public abstract class BaseTable : Java.Lang.Object {

		internal BaseTable ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.tables']/interface[@name='BaseTable']/field[@name='KEY_ID']"
		[Register ("KEY_ID")]
		public const string KeyId = (string) "_id";
	}

	[Register ("com/liveperson/infra/database/tables/BaseTable", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BaseTable' type. This type will be removed in a future release.")]
	public abstract class BaseTableConsts : BaseTable {

		private BaseTableConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.database.tables']/interface[@name='BaseTable']"
	[Register ("com/liveperson/infra/database/tables/BaseTable", "", "Com.Liveperson.Infra.Database.Tables.IBaseTableInvoker")]
	public partial interface IBaseTable : IJavaObject {

		string CreateSQL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/interface[@name='BaseTable']/method[@name='getCreateSQL' and count(parameter)=0]"
			[Register ("getCreateSQL", "()Ljava/lang/String;", "GetGetCreateSQLHandler:Com.Liveperson.Infra.Database.Tables.IBaseTableInvoker, LP_Infra_Binding")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/interface[@name='BaseTable']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Liveperson.Infra.Database.Tables.IBaseTableInvoker, LP_Infra_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.tables']/interface[@name='BaseTable']/method[@name='onTableUpgrade' and count(parameter)=3 and parameter[1][@type='android.database.sqlite.SQLiteDatabase'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onTableUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V", "GetOnTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_IIHandler:Com.Liveperson.Infra.Database.Tables.IBaseTableInvoker, LP_Infra_Binding")]
		void OnTableUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/database/tables/BaseTable", DoNotGenerateAcw=true)]
	internal class IBaseTableInvoker : global::Java.Lang.Object, IBaseTable {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/database/tables/BaseTable");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBaseTableInvoker); }
		}

		IntPtr class_ref;

		public static IBaseTable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseTable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.database.tables.BaseTable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseTableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Liveperson.Infra.Database.Tables.IBaseTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.IBaseTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateSQL);
		}
#pragma warning restore 0169

		IntPtr id_getCreateSQL;
		public unsafe string CreateSQL {
			get {
				if (id_getCreateSQL == IntPtr.Zero)
					id_getCreateSQL = JNIEnv.GetMethodID (class_ref, "getCreateSQL", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreateSQL), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Database.Tables.IBaseTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.IBaseTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.Database.Tables.IBaseTable __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Tables.IBaseTable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase p0 = global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTableUpgrade (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II;
		public unsafe void OnTableUpgrade (global::Android.Database.Sqlite.SQLiteDatabase p0, int p1, int p2)
		{
			if (id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II == IntPtr.Zero)
				id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II = JNIEnv.GetMethodID (class_ref, "onTableUpgrade", "(Landroid/database/sqlite/SQLiteDatabase;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTableUpgrade_Landroid_database_sqlite_SQLiteDatabase_II, __args);
		}

	}

}
