using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Uicomponents {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IConversationProvider']"
	[Register ("com/liveperson/infra/ui/view/uicomponents/IConversationProvider", "", "Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProviderInvoker")]
	public partial interface IConversationProvider : IJavaObject {

		string BrandId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IConversationProvider']/method[@name='getBrandId' and count(parameter)=0]"
			[Register ("getBrandId", "()Ljava/lang/String;", "GetGetBrandIdHandler:Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProviderInvoker, LP_Android_aar_Binding")] get;
		}

		string TargetId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.uicomponents']/interface[@name='IConversationProvider']/method[@name='getTargetId' and count(parameter)=0]"
			[Register ("getTargetId", "()Ljava/lang/String;", "GetGetTargetIdHandler:Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProviderInvoker, LP_Android_aar_Binding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/uicomponents/IConversationProvider", DoNotGenerateAcw=true)]
	internal class IConversationProviderInvoker : global::Java.Lang.Object, IConversationProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/uicomponents/IConversationProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConversationProviderInvoker); }
		}

		IntPtr class_ref;

		public static IConversationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConversationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.uicomponents.IConversationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConversationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
