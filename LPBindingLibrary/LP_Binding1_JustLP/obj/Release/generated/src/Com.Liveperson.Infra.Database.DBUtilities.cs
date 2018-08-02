using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/DBUtilities", DoNotGenerateAcw=true)]
	public partial class DBUtilities : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/field[@name='ROW_UPDATED']"
		[Register ("ROW_UPDATED")]
		public const long RowUpdated = (long) -1L;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/DBUtilities", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DBUtilities); }
		}

		protected DBUtilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_insert_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsert_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insert_Landroid_content_ContentValues_ == null)
				cb_insert_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Insert_Landroid_content_ContentValues_);
			return cb_insert_Landroid_content_ContentValues_;
		}

		static long n_Insert_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Insert (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insert_Landroid_content_ContentValues_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='insert' and count(parameter)=1 and parameter[1][@type='android.content.ContentValues']]"
		[Register ("insert", "(Landroid/content/ContentValues;)J", "GetInsert_Landroid_content_ContentValues_Handler")]
		public virtual unsafe long Insert (global::Android.Content.ContentValues p0)
		{
			if (id_insert_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_insert_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "insert", "(Landroid/content/ContentValues;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_insert_Landroid_content_ContentValues_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insert", "(Landroid/content/ContentValues;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_insertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInsertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_insertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_insertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long>) n_InsertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_insertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static long n_InsertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p1 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string[] p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			long __ret = __this.InsertOrUpdate (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='insertOrUpdate' and count(parameter)=4 and parameter[1][@type='android.content.ContentValues'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("insertOrUpdate", "(Landroid/content/ContentValues;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)J", "GetInsertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe long InsertOrUpdate (global::Android.Content.ContentValues p0, global::Android.Content.ContentValues p1, string p2, string[] p3)
		{
			if (id_insertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_insertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "insertOrUpdate", "(Landroid/content/ContentValues;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)J");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_insertOrUpdate_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insertOrUpdate", "(Landroid/content/ContentValues;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_insertWithOnConflict_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetInsertWithOnConflict_Landroid_content_ContentValues_Handler ()
		{
			if (cb_insertWithOnConflict_Landroid_content_ContentValues_ == null)
				cb_insertWithOnConflict_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_InsertWithOnConflict_Landroid_content_ContentValues_);
			return cb_insertWithOnConflict_Landroid_content_ContentValues_;
		}

		static long n_InsertWithOnConflict_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.InsertWithOnConflict (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_insertWithOnConflict_Landroid_content_ContentValues_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='insertWithOnConflict' and count(parameter)=1 and parameter[1][@type='android.content.ContentValues']]"
		[Register ("insertWithOnConflict", "(Landroid/content/ContentValues;)J", "GetInsertWithOnConflict_Landroid_content_ContentValues_Handler")]
		public virtual unsafe long InsertWithOnConflict (global::Android.Content.ContentValues p0)
		{
			if (id_insertWithOnConflict_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_insertWithOnConflict_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "insertWithOnConflict", "(Landroid/content/ContentValues;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_insertWithOnConflict_Landroid_content_ContentValues_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "insertWithOnConflict", "(Landroid/content/ContentValues;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1, p2, p3, p4, p5));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='query' and count(parameter)=6 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("query", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Database.ICursor Query (string[] p0, string p1, string[] p2, string p3, string p4, string p5)
		{
			if (id_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "query", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQuery_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Query (p0, p1, p2, p3, p4, p5, p6));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='query' and count(parameter)=7 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("query", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", "GetQuery_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Database.ICursor Query (string[] p0, string p1, string[] p2, string p3, string p4, string p5, string p6)
		{
			if (id_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "query", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query_arrayLjava_lang_String_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "query", "([Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_rawQuery_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRawQuery_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_rawQuery_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_rawQuery_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RawQuery_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_rawQuery_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_RawQuery_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RawQuery (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rawQuery_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='rawQuery' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("rawQuery", "(Ljava/lang/String;[Ljava/lang/Object;)Landroid/database/Cursor;", "GetRawQuery_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Android.Database.ICursor RawQuery (string p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_rawQuery_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_rawQuery_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "rawQuery", "(Ljava/lang/String;[Ljava/lang/Object;)Landroid/database/Cursor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Android.Database.ICursor __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_rawQuery_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rawQuery", "(Ljava/lang/String;[Ljava/lang/Object;)Landroid/database/Cursor;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_removeAll_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAll_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_removeAll_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_removeAll_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_RemoveAll_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_removeAll_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_RemoveAll_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.RemoveAll (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeAll_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='removeAll' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("removeAll", "(Ljava/lang/String;[Ljava/lang/String;)I", "GetRemoveAll_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe int RemoveAll (string p0, string[] p1)
		{
			if (id_removeAll_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_removeAll_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAll", "(Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_removeAll_Ljava_lang_String_arrayLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "(Ljava/lang/String;[Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_replace_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetReplace_Landroid_content_ContentValues_Handler ()
		{
			if (cb_replace_Landroid_content_ContentValues_ == null)
				cb_replace_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Replace_Landroid_content_ContentValues_);
			return cb_replace_Landroid_content_ContentValues_;
		}

		static long n_Replace_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Replace (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_replace_Landroid_content_ContentValues_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='replace' and count(parameter)=1 and parameter[1][@type='android.content.ContentValues']]"
		[Register ("replace", "(Landroid/content/ContentValues;)J", "GetReplace_Landroid_content_ContentValues_Handler")]
		public virtual unsafe long Replace (global::Android.Content.ContentValues p0)
		{
			if (id_replace_Landroid_content_ContentValues_ == IntPtr.Zero)
				id_replace_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "replace", "(Landroid/content/ContentValues;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_replace_Landroid_content_ContentValues_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replace", "(Landroid/content/ContentValues;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_runTransaction_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetRunTransaction_Ljava_util_List_Handler ()
		{
			if (cb_runTransaction_Ljava_util_List_ == null)
				cb_runTransaction_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunTransaction_Ljava_util_List_);
			return cb_runTransaction_Ljava_util_List_;
		}

		static void n_RunTransaction_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RunTransaction (p0);
		}
#pragma warning restore 0169

		static IntPtr id_runTransaction_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='runTransaction' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.liveperson.infra.database.transaction_helper.SQLiteCommand&gt;']]"
		[Register ("runTransaction", "(Ljava/util/List;)V", "GetRunTransaction_Ljava_util_List_Handler")]
		public virtual unsafe void RunTransaction (global::System.Collections.Generic.IList<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand> p0)
		{
			if (id_runTransaction_Ljava_util_List_ == IntPtr.Zero)
				id_runTransaction_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "runTransaction", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runTransaction_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runTransaction", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdate_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static int n_Update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Database.DBUtilities __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ContentValues p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string[] p2 = (string[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (string));
			int __ret = __this.Update (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DBUtilities']/method[@name='update' and count(parameter)=3 and parameter[1][@type='android.content.ContentValues'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register ("update", "(Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", "GetUpdate_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe int Update (global::Android.Content.ContentValues p0, string p1, string[] p2)
		{
			if (id_update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "update", "(Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_update_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "update", "(Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
