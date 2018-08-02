using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/DataBaseCommand", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"DATA"})]
	public partial class DataBaseCommand : global::Java.Lang.Object {


		static IntPtr mPostQueryOnBackground_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/field[@name='mPostQueryOnBackground']"
		[Register ("mPostQueryOnBackground")]
		protected global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback MPostQueryOnBackground {
			get {
				if (mPostQueryOnBackground_jfieldId == IntPtr.Zero)
					mPostQueryOnBackground_jfieldId = JNIEnv.GetFieldID (class_ref, "mPostQueryOnBackground", "Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPostQueryOnBackground_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPostQueryOnBackground_jfieldId == IntPtr.Zero)
					mPostQueryOnBackground_jfieldId = JNIEnv.GetFieldID (class_ref, "mPostQueryOnBackground", "Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPostQueryOnBackground_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPostQueryOnUI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/field[@name='mPostQueryOnUI']"
		[Register ("mPostQueryOnUI")]
		protected global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback MPostQueryOnUI {
			get {
				if (mPostQueryOnUI_jfieldId == IntPtr.Zero)
					mPostQueryOnUI_jfieldId = JNIEnv.GetFieldID (class_ref, "mPostQueryOnUI", "Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPostQueryOnUI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPostQueryOnUI_jfieldId == IntPtr.Zero)
					mPostQueryOnUI_jfieldId = JNIEnv.GetFieldID (class_ref, "mPostQueryOnUI", "Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPostQueryOnUI_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mPreQueryOnBackground_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/field[@name='mPreQueryOnBackground']"
		[Register ("mPreQueryOnBackground")]
		protected global::Java.Lang.IRunnable MPreQueryOnBackground {
			get {
				if (mPreQueryOnBackground_jfieldId == IntPtr.Zero)
					mPreQueryOnBackground_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreQueryOnBackground", "Ljava/lang/Runnable;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mPreQueryOnBackground_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPreQueryOnBackground_jfieldId == IntPtr.Zero)
					mPreQueryOnBackground_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreQueryOnBackground", "Ljava/lang/Runnable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mPreQueryOnBackground_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.database']/interface[@name='DataBaseCommand.QueryCallback']"
		[Register ("com/liveperson/infra/database/DataBaseCommand$QueryCallback", "", "Com.Liveperson.Infra.Database.DataBaseCommand/IQueryCallbackInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IQueryCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/interface[@name='DataBaseCommand.QueryCallback']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("onResult", "(Ljava/lang/Object;)V", "GetOnResult_Ljava_lang_Object_Handler:Com.Liveperson.Infra.Database.DataBaseCommand/IQueryCallbackInvoker, LP_Binding1_JustLP")]
			void OnResult (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/database/DataBaseCommand$QueryCallback", DoNotGenerateAcw=true)]
		internal class IQueryCallbackInvoker : global::Java.Lang.Object, IQueryCallback {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/database/DataBaseCommand$QueryCallback");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IQueryCallbackInvoker); }
			}

			IntPtr class_ref;

			public static IQueryCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQueryCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.database.DataBaseCommand.QueryCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQueryCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onResult_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnResult_Ljava_lang_Object_Handler ()
			{
				if (cb_onResult_Ljava_lang_Object_ == null)
					cb_onResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResult_Ljava_lang_Object_);
				return cb_onResult_Ljava_lang_Object_;
			}

			static void n_OnResult_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResult (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResult_Ljava_lang_Object_;
			public unsafe void OnResult (global::Java.Lang.Object p0)
			{
				if (id_onResult_Ljava_lang_Object_ == IntPtr.Zero)
					id_onResult_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.database']/interface[@name='DataBaseCommand.QueryCommand']"
		[Register ("com/liveperson/infra/database/DataBaseCommand$QueryCommand", "", "Com.Liveperson.Infra.Database.DataBaseCommand/IQueryCommandInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IQueryCommand : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/interface[@name='DataBaseCommand.QueryCommand']/method[@name='query' and count(parameter)=0]"
			[Register ("query", "()Ljava/lang/Object;", "GetQueryHandler:Com.Liveperson.Infra.Database.DataBaseCommand/IQueryCommandInvoker, LP_Binding1_JustLP")]
			global::Java.Lang.Object Query ();

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/database/DataBaseCommand$QueryCommand", DoNotGenerateAcw=true)]
		internal class IQueryCommandInvoker : global::Java.Lang.Object, IQueryCommand {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/database/DataBaseCommand$QueryCommand");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IQueryCommandInvoker); }
			}

			IntPtr class_ref;

			public static IQueryCommand GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQueryCommand> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.database.DataBaseCommand.QueryCommand"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQueryCommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_query;
#pragma warning disable 0169
			static Delegate GetQueryHandler ()
			{
				if (cb_query == null)
					cb_query = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Query);
				return cb_query;
			}

			static IntPtr n_Query (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Query ());
			}
#pragma warning restore 0169

			IntPtr id_query;
			public unsafe global::Java.Lang.Object Query ()
			{
				if (id_query == IntPtr.Zero)
					id_query = JNIEnv.GetMethodID (class_ref, "query", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_query), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/DataBaseCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataBaseCommand); }
		}

		protected DataBaseCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/constructor[@name='DataBaseCommand' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.DataBaseCommand.QueryCommand&lt;DATA&gt;']]"
		[Register (".ctor", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCommand;)V", "")]
		public unsafe DataBaseCommand (global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCommand p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (DataBaseCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCommand;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCommand;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCommand;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_, __args);
			} finally {
			}
		}

		static IntPtr id_create_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/method[@name='create' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.DataBaseCommand.QueryCommand&lt;DATA&gt;']]"
		[Register ("create", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCommand;)Lcom/liveperson/infra/database/DataBaseCommand;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"DATA"})]
		public static unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand Create (global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCommand p0)
		{
			if (id_create_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_ == IntPtr.Zero)
				id_create_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCommand;)Lcom/liveperson/infra/database/DataBaseCommand;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_liveperson_infra_database_DataBaseCommand_QueryCommand_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.DataBaseCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

		static Delegate cb_executeSynchronously;
#pragma warning disable 0169
		static Delegate GetExecuteSynchronouslyHandler ()
		{
			if (cb_executeSynchronously == null)
				cb_executeSynchronously = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExecuteSynchronously);
			return cb_executeSynchronously;
		}

		static IntPtr n_ExecuteSynchronously (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.DataBaseCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExecuteSynchronously ());
		}
#pragma warning restore 0169

		static IntPtr id_executeSynchronously;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/method[@name='executeSynchronously' and count(parameter)=0]"
		[Register ("executeSynchronously", "()Ljava/lang/Object;", "GetExecuteSynchronouslyHandler")]
		public virtual unsafe global::Java.Lang.Object ExecuteSynchronously ()
		{
			if (id_executeSynchronously == IntPtr.Zero)
				id_executeSynchronously = JNIEnv.GetMethodID (class_ref, "executeSynchronously", "()Ljava/lang/Object;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_executeSynchronously), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "executeSynchronously", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_;
#pragma warning disable 0169
		static Delegate GetSetPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_Handler ()
		{
			if (cb_setPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ == null)
				cb_setPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_);
			return cb_setPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_;
		}

		static IntPtr n_SetPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.DataBaseCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback p0 = (global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPostQueryOnBackground (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/method[@name='setPostQueryOnBackground' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.DataBaseCommand.QueryCallback&lt;DATA&gt;']]"
		[Register ("setPostQueryOnBackground", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetSetPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand SetPostQueryOnBackground (global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback p0)
		{
			if (id_setPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ == IntPtr.Zero)
				id_setPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ = JNIEnv.GetMethodID (class_ref, "setPostQueryOnBackground", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;)Lcom/liveperson/infra/database/DataBaseCommand;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPostQueryOnBackground_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPostQueryOnBackground", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_;
#pragma warning disable 0169
		static Delegate GetSetPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_Handler ()
		{
			if (cb_setPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ == null)
				cb_setPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_);
			return cb_setPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_;
		}

		static IntPtr n_SetPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.DataBaseCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback p0 = (global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPostQueryOnUI (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/method[@name='setPostQueryOnUI' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.database.DataBaseCommand.QueryCallback&lt;DATA&gt;']]"
		[Register ("setPostQueryOnUI", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetSetPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand SetPostQueryOnUI (global::Com.Liveperson.Infra.Database.DataBaseCommand.IQueryCallback p0)
		{
			if (id_setPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ == IntPtr.Zero)
				id_setPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_ = JNIEnv.GetMethodID (class_ref, "setPostQueryOnUI", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;)Lcom/liveperson/infra/database/DataBaseCommand;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPostQueryOnUI_Lcom_liveperson_infra_database_DataBaseCommand_QueryCallback_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPostQueryOnUI", "(Lcom/liveperson/infra/database/DataBaseCommand$QueryCallback;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setPreQueryOnBackground_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSetPreQueryOnBackground_Ljava_lang_Runnable_Handler ()
		{
			if (cb_setPreQueryOnBackground_Ljava_lang_Runnable_ == null)
				cb_setPreQueryOnBackground_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPreQueryOnBackground_Ljava_lang_Runnable_);
			return cb_setPreQueryOnBackground_Ljava_lang_Runnable_;
		}

		static IntPtr n_SetPreQueryOnBackground_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Database.DataBaseCommand __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPreQueryOnBackground (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPreQueryOnBackground_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='DataBaseCommand']/method[@name='setPreQueryOnBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("setPreQueryOnBackground", "(Ljava/lang/Runnable;)Lcom/liveperson/infra/database/DataBaseCommand;", "GetSetPreQueryOnBackground_Ljava_lang_Runnable_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.Database.DataBaseCommand SetPreQueryOnBackground (global::Java.Lang.IRunnable p0)
		{
			if (id_setPreQueryOnBackground_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setPreQueryOnBackground_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "setPreQueryOnBackground", "(Ljava/lang/Runnable;)Lcom/liveperson/infra/database/DataBaseCommand;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.Database.DataBaseCommand __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPreQueryOnBackground_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DataBaseCommand> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreQueryOnBackground", "(Ljava/lang/Runnable;)Lcom/liveperson/infra/database/DataBaseCommand;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
