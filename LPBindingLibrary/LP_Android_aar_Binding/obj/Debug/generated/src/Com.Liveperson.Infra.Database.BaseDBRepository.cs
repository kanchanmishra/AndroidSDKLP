using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='BaseDBRepository']"
	[global::Android.Runtime.Register ("com/liveperson/infra/database/BaseDBRepository", DoNotGenerateAcw=true)]
	public abstract partial class BaseDBRepository : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/database/BaseDBRepository", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseDBRepository); }
		}

		protected BaseDBRepository (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='BaseDBRepository']/constructor[@name='BaseDBRepository' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BaseDBRepository (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (BaseDBRepository)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDB;
#pragma warning disable 0169
		static Delegate GetGetDBHandler ()
		{
			if (cb_getDB == null)
				cb_getDB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDB);
			return cb_getDB;
		}

		static IntPtr n_GetDB (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Database.BaseDBRepository __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.BaseDBRepository> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DB);
		}
#pragma warning restore 0169

		static IntPtr id_getDB;
		protected virtual unsafe global::Com.Liveperson.Infra.Database.DBUtilities DB {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.database']/class[@name='BaseDBRepository']/method[@name='getDB' and count(parameter)=0]"
			[Register ("getDB", "()Lcom/liveperson/infra/database/DBUtilities;", "GetGetDBHandler")]
			get {
				if (id_getDB == IntPtr.Zero)
					id_getDB = JNIEnv.GetMethodID (class_ref, "getDB", "()Lcom/liveperson/infra/database/DBUtilities;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDB), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Database.DBUtilities> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDB", "()Lcom/liveperson/infra/database/DBUtilities;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/database/BaseDBRepository", DoNotGenerateAcw=true)]
	internal partial class BaseDBRepositoryInvoker : BaseDBRepository {

		public BaseDBRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseDBRepositoryInvoker); }
		}

	}

}
