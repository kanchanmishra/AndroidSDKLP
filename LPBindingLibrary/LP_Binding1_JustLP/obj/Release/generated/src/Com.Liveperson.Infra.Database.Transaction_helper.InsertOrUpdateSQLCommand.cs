using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database.Transaction_helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='InsertOrUpdateSQLCommand']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/transaction_helper/InsertOrUpdateSQLCommand", DoNotGenerateAcw=true)]
	public partial class InsertOrUpdateSQLCommand : global::Com.Liveperson.Infra.Database.Transaction_helper.UpdateSQLCommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/transaction_helper/InsertOrUpdateSQLCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InsertOrUpdateSQLCommand); }
		}

		protected InsertOrUpdateSQLCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='InsertOrUpdateSQLCommand']/constructor[@name='InsertOrUpdateSQLCommand' and count(parameter)=4 and parameter[1][@type='android.content.ContentValues'] and parameter[2][@type='android.content.ContentValues'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register (".ctor", "(Landroid/content/ContentValues;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe InsertOrUpdateSQLCommand (global::Android.Content.ContentValues p0, global::Android.Content.ContentValues p1, string p2, string[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (InsertOrUpdateSQLCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/ContentValues;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/ContentValues;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/ContentValues;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_ContentValues_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_getContentValuesForInsert;
#pragma warning disable 0169
		static Delegate GetGetContentValuesForInsertHandler ()
		{
			if (cb_getContentValuesForInsert == null)
				cb_getContentValuesForInsert = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentValuesForInsert);
			return cb_getContentValuesForInsert;
		}

		static IntPtr n_GetContentValuesForInsert (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.Transaction_helper.InsertOrUpdateSQLCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.InsertOrUpdateSQLCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentValuesForInsert);
		}
#pragma warning restore 0169

		static IntPtr id_getContentValuesForInsert;
		public virtual unsafe global::Android.Content.ContentValues ContentValuesForInsert {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='InsertOrUpdateSQLCommand']/method[@name='getContentValuesForInsert' and count(parameter)=0]"
			[Register ("getContentValuesForInsert", "()Landroid/content/ContentValues;", "GetGetContentValuesForInsertHandler")]
			get {
				if (id_getContentValuesForInsert == IntPtr.Zero)
					id_getContentValuesForInsert = JNIEnv.GetMethodID (class_ref, "getContentValuesForInsert", "()Landroid/content/ContentValues;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentValuesForInsert), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentValuesForInsert", "()Landroid/content/ContentValues;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentValuesForUpdate;
#pragma warning disable 0169
		static Delegate GetGetContentValuesForUpdateHandler ()
		{
			if (cb_getContentValuesForUpdate == null)
				cb_getContentValuesForUpdate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentValuesForUpdate);
			return cb_getContentValuesForUpdate;
		}

		static IntPtr n_GetContentValuesForUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.Transaction_helper.InsertOrUpdateSQLCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.InsertOrUpdateSQLCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentValuesForUpdate);
		}
#pragma warning restore 0169

		static IntPtr id_getContentValuesForUpdate;
		public virtual unsafe global::Android.Content.ContentValues ContentValuesForUpdate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='InsertOrUpdateSQLCommand']/method[@name='getContentValuesForUpdate' and count(parameter)=0]"
			[Register ("getContentValuesForUpdate", "()Landroid/content/ContentValues;", "GetGetContentValuesForUpdateHandler")]
			get {
				if (id_getContentValuesForUpdate == IntPtr.Zero)
					id_getContentValuesForUpdate = JNIEnv.GetMethodID (class_ref, "getContentValuesForUpdate", "()Landroid/content/ContentValues;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentValuesForUpdate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentValuesForUpdate", "()Landroid/content/ContentValues;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
