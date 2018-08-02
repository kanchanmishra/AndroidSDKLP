using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database.Transaction_helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='SQLiteCommand']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/transaction_helper/SQLiteCommand", DoNotGenerateAcw=true)]
	public abstract partial class SQLiteCommand : global::Java.Lang.Object {


		static IntPtr mListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='SQLiteCommand']/field[@name='mListener']"
		[Register ("mListener")]
		protected global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener MListener {
			get {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lcom/liveperson/infra/database/transaction_helper/SQLiteCommand$SQLiteCommandListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lcom/liveperson/infra/database/transaction_helper/SQLiteCommand$SQLiteCommandListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		[Register ("com/liveperson/infra/database/transaction_helper/SQLiteCommand$CommandType", DoNotGenerateAcw=true)]
		public abstract class CommandType : Java.Lang.Object {

			internal CommandType ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/interface[@name='SQLiteCommand.CommandType']/field[@name='INSERT']"
			[Register ("INSERT")]
			public const int Insert = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/interface[@name='SQLiteCommand.CommandType']/field[@name='INSERT_OR_UPDATE']"
			[Register ("INSERT_OR_UPDATE")]
			public const int InsertOrUpdate = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/interface[@name='SQLiteCommand.CommandType']/field[@name='UPDATE']"
			[Register ("UPDATE")]
			public const int Update = (int) 1;
		}

		[Register ("com/liveperson/infra/database/transaction_helper/SQLiteCommand$CommandType", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'CommandType' type. This type will be removed in a future release.")]
		public abstract class CommandTypeConsts : CommandType {

			private CommandTypeConsts ()
			{
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/interface[@name='SQLiteCommand.SQLiteCommandListener']"
		[Register ("com/liveperson/infra/database/transaction_helper/SQLiteCommand$SQLiteCommandListener", "", "Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand/ISQLiteCommandListenerInvoker")]
		public partial interface ISQLiteCommandListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/interface[@name='SQLiteCommand.SQLiteCommandListener']/method[@name='onInsertComplete' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("onInsertComplete", "(J)V", "GetOnInsertComplete_JHandler:Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand/ISQLiteCommandListenerInvoker, LP_Infra_Binding")]
			void OnInsertComplete (long p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/database/transaction_helper/SQLiteCommand$SQLiteCommandListener", DoNotGenerateAcw=true)]
		internal class ISQLiteCommandListenerInvoker : global::Java.Lang.Object, ISQLiteCommandListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/database/transaction_helper/SQLiteCommand$SQLiteCommandListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISQLiteCommandListenerInvoker); }
			}

			IntPtr class_ref;

			public static ISQLiteCommandListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISQLiteCommandListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.database.transaction_helper.SQLiteCommand.SQLiteCommandListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISQLiteCommandListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInsertComplete_J;
#pragma warning disable 0169
			static Delegate GetOnInsertComplete_JHandler ()
			{
				if (cb_onInsertComplete_J == null)
					cb_onInsertComplete_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnInsertComplete_J);
				return cb_onInsertComplete_J;
			}

			static void n_OnInsertComplete_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInsertComplete (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInsertComplete_J;
			public unsafe void OnInsertComplete (long p0)
			{
				if (id_onInsertComplete_J == IntPtr.Zero)
					id_onInsertComplete_J = JNIEnv.GetMethodID (class_ref, "onInsertComplete", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInsertComplete_J, __args);
			}

		}

		public partial class SQLiteCommandEventArgs : global::System.EventArgs {

			public SQLiteCommandEventArgs (long p0)
			{
				this.p0 = p0;
			}

			long p0;
			public long P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/liveperson/infra/database/transaction_helper/SQLiteCommand_SQLiteCommandListenerImplementor")]
		internal sealed partial class ISQLiteCommandListenerImplementor : global::Java.Lang.Object, ISQLiteCommandListener {

			object sender;

			public ISQLiteCommandListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/database/transaction_helper/SQLiteCommand_SQLiteCommandListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SQLiteCommandEventArgs> Handler;
#pragma warning restore 0649

			public void OnInsertComplete (long p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SQLiteCommandEventArgs (p0));
			}

			internal static bool __IsEmpty (ISQLiteCommandListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/transaction_helper/SQLiteCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SQLiteCommand); }
		}

		protected SQLiteCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_ContentValues_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='SQLiteCommand']/constructor[@name='SQLiteCommand' and count(parameter)=1 and parameter[1][@type='android.content.ContentValues']]"
		[Register (".ctor", "(Landroid/content/ContentValues;)V", "")]
		public unsafe SQLiteCommand (global::Android.Content.ContentValues p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SQLiteCommand)) {
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

		static Delegate cb_getContentValues;
#pragma warning disable 0169
		static Delegate GetGetContentValuesHandler ()
		{
			if (cb_getContentValues == null)
				cb_getContentValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentValues);
			return cb_getContentValues;
		}

		static IntPtr n_GetContentValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentValues);
		}
#pragma warning restore 0169

		static IntPtr id_getContentValues;
		public virtual unsafe global::Android.Content.ContentValues ContentValues {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='SQLiteCommand']/method[@name='getContentValues' and count(parameter)=0]"
			[Register ("getContentValues", "()Landroid/content/ContentValues;", "GetGetContentValuesHandler")]
			get {
				if (id_getContentValues == IntPtr.Zero)
					id_getContentValues = JNIEnv.GetMethodID (class_ref, "getContentValues", "()Landroid/content/ContentValues;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentValues), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentValues", "()Landroid/content/ContentValues;")), JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		public abstract int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='SQLiteCommand']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")] get;
		}

		static Delegate cb_onInserted_J;
#pragma warning disable 0169
		static Delegate GetOnInserted_JHandler ()
		{
			if (cb_onInserted_J == null)
				cb_onInserted_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnInserted_J);
			return cb_onInserted_J;
		}

		static void n_OnInserted_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInserted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onInserted_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='SQLiteCommand']/method[@name='onInserted' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onInserted", "(J)V", "GetOnInserted_JHandler")]
		public virtual unsafe void OnInserted (long p0)
		{
			if (id_onInserted_J == IntPtr.Zero)
				id_onInserted_J = JNIEnv.GetMethodID (class_ref, "onInserted", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInserted_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInserted", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_Handler ()
		{
			if (cb_setListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_ == null)
				cb_setListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_);
			return cb_setListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_;
		}

		static void n_SetListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener p0 = (global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='SQLiteCommand']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.transaction_helper.SQLiteCommand.SQLiteCommandListener']]"
		[Register ("setListener", "(Lcom/liveperson/infra/database/transaction_helper/SQLiteCommand$SQLiteCommandListener;)V", "GetSetListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_Handler")]
		public virtual unsafe void SetListener (global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener p0)
		{
			if (id_setListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_ == IntPtr.Zero)
				id_setListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/liveperson/infra/database/transaction_helper/SQLiteCommand$SQLiteCommandListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_liveperson_infra_database_transaction_helper_SQLiteCommand_SQLiteCommandListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/liveperson/infra/database/transaction_helper/SQLiteCommand$SQLiteCommandListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListener"

		global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListenerImplementor __CreateISQLiteCommandListenerImplementor ()
		{
			return new global::Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand.ISQLiteCommandListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/liveperson/infra/database/transaction_helper/SQLiteCommand", DoNotGenerateAcw=true)]
	internal partial class SQLiteCommandInvoker : SQLiteCommand {

		public SQLiteCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SQLiteCommandInvoker); }
		}

		static IntPtr id_getType;
		public override unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database.transaction_helper']/class[@name='SQLiteCommand']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
				} finally {
				}
			}
		}

	}

}
