using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='CursorLoaderFactory']"
	[Register ("com/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactoryInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends android.support.v4.content.CursorLoader"})]
	public partial interface ICursorLoaderFactory : IJavaObject {

		string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='CursorLoaderFactory']/method[@name='getBrandId' and count(parameter)=0]"
			[Register ("getBrandId", "()Ljava/lang/String;", "GetGetBrandIdHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactoryInvoker, LP_Android_aar_Binding")] get;
		}

		string TargetId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='CursorLoaderFactory']/method[@name='getTargetId' and count(parameter)=0]"
			[Register ("getTargetId", "()Ljava/lang/String;", "GetGetTargetIdHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactoryInvoker, LP_Android_aar_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='CursorLoaderFactory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Landroid/support/v4/content/CursorLoader;", "GetCreateHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactoryInvoker, LP_Android_aar_Binding")]
		global::Java.Lang.Object Create ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory", DoNotGenerateAcw=true)]
	internal class ICursorLoaderFactoryInvoker : global::Java.Lang.Object, ICursorLoaderFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICursorLoaderFactoryInvoker); }
		}

		IntPtr class_ref;

		public static ICursorLoaderFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICursorLoaderFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.CursorLoaderFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICursorLoaderFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBrandId;
#pragma warning disable 0169
		static Delegate GetGetBrandIdHandler ()
		{
			if (cb_getBrandId == null)
				cb_getBrandId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBrandId);
			return cb_getBrandId;
		}

		static IntPtr n_GetBrandId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BrandId);
		}
#pragma warning restore 0169

		IntPtr id_getBrandId;
		public unsafe string BrandId {
			get {
				if (id_getBrandId == IntPtr.Zero)
					id_getBrandId = JNIEnv.GetMethodID (class_ref, "getBrandId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrandId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTargetId;
#pragma warning disable 0169
		static Delegate GetGetTargetIdHandler ()
		{
			if (cb_getTargetId == null)
				cb_getTargetId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetId);
			return cb_getTargetId;
		}

		static IntPtr n_GetTargetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetId);
		}
#pragma warning restore 0169

		IntPtr id_getTargetId;
		public unsafe string TargetId {
			get {
				if (id_getTargetId == IntPtr.Zero)
					id_getTargetId = JNIEnv.GetMethodID (class_ref, "getTargetId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Create);
			return cb_create;
		}

		static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Create ());
		}
#pragma warning restore 0169

		IntPtr id_create;
		public unsafe global::Java.Lang.Object Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()Landroid/support/v4/content/CursorLoader;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create), JniHandleOwnership.TransferLocalRef);
		}

	}

}
