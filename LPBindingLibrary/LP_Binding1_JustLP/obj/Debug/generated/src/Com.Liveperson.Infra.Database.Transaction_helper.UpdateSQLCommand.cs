using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database.Transaction_helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='UpdateSQLCommand']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/transaction_helper/UpdateSQLCommand", DoNotGenerateAcw=true)]
	public partial class UpdateSQLCommand : global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/transaction_helper/UpdateSQLCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UpdateSQLCommand); }
		}

		protected UpdateSQLCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='UpdateSQLCommand']/constructor[@name='UpdateSQLCommand' and count(parameter)=3 and parameter[1][@type='android.content.ContentValues'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String[]']]"
		[Register (".ctor", "(Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe UpdateSQLCommand (global::Android.Content.ContentValues p0, string p1, string[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (UpdateSQLCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_ContentValues_Ljava_lang_String_arrayLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.Transaction_helper.UpdateSQLCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.UpdateSQLCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='UpdateSQLCommand']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUpdateWhereClause;
#pragma warning disable 0169
		static Delegate GetGetUpdateWhereClauseHandler ()
		{
			if (cb_getUpdateWhereClause == null)
				cb_getUpdateWhereClause = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateWhereClause);
			return cb_getUpdateWhereClause;
		}

		static IntPtr n_GetUpdateWhereClause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.Transaction_helper.UpdateSQLCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.UpdateSQLCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UpdateWhereClause);
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateWhereClause;
		public virtual unsafe string UpdateWhereClause {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='UpdateSQLCommand']/method[@name='getUpdateWhereClause' and count(parameter)=0]"
			[Register ("getUpdateWhereClause", "()Ljava/lang/String;", "GetGetUpdateWhereClauseHandler")]
			get {
				if (id_getUpdateWhereClause == IntPtr.Zero)
					id_getUpdateWhereClause = JNIEnv.GetMethodID (class_ref, "getUpdateWhereClause", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateWhereClause), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateWhereClause", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdateWhereArgs;
#pragma warning disable 0169
		static Delegate GetGetUpdateWhereArgsHandler ()
		{
			if (cb_getUpdateWhereArgs == null)
				cb_getUpdateWhereArgs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateWhereArgs);
			return cb_getUpdateWhereArgs;
		}

		static IntPtr n_GetUpdateWhereArgs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.Transaction_helper.UpdateSQLCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.UpdateSQLCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetUpdateWhereArgs ());
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateWhereArgs;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='UpdateSQLCommand']/method[@name='getUpdateWhereArgs' and count(parameter)=0]"
		[Register ("getUpdateWhereArgs", "()[Ljava/lang/String;", "GetGetUpdateWhereArgsHandler")]
		public virtual unsafe string[] GetUpdateWhereArgs ()
		{
			if (id_getUpdateWhereArgs == IntPtr.Zero)
				id_getUpdateWhereArgs = JNIEnv.GetMethodID (class_ref, "getUpdateWhereArgs", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateWhereArgs), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateWhereArgs", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
