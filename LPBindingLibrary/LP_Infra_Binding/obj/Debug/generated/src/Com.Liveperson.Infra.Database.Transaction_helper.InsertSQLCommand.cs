using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database.Transaction_helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='InsertSQLCommand']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/transaction_helper/InsertSQLCommand", DoNotGenerateAcw=true)]
	public partial class InsertSQLCommand : global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/transaction_helper/InsertSQLCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InsertSQLCommand); }
		}

		protected InsertSQLCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_ContentValues_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='InsertSQLCommand']/constructor[@name='InsertSQLCommand' and count(parameter)=1 and parameter[1][@type='android.content.ContentValues']]"
		[Register (".ctor", "(Landroid/content/ContentValues;)V", "")]
		public unsafe InsertSQLCommand (global::Android.Content.ContentValues p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (InsertSQLCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/ContentValues;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/ContentValues;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_ContentValues_ == IntPtr.Zero)
					id_ctor_Landroid_content_ContentValues_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/ContentValues;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_ContentValues_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_ContentValues_, __args);
			} finally {
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
			global::Com.Liveperson.Infra.Database.Transaction_helper.InsertSQLCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.InsertSQLCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='InsertSQLCommand']/method[@name='getType' and count(parameter)=0]"
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

	}
}
