using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LinkPreviewCallback']"
	[Register ("com/liveperson/infra/utils/LinkPreviewCallback", "", "Com.Liveperson.Infra.Utils.ILinkPreviewCallbackInvoker")]
	public partial interface ILinkPreviewCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LinkPreviewCallback']/method[@name='clean' and count(parameter)=0]"
		[Register ("clean", "()V", "GetCleanHandler:Com.Liveperson.Infra.Utils.ILinkPreviewCallbackInvoker, LP_Binding1_JustLP")]
		void Clean ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LinkPreviewCallback']/method[@name='onPos' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.utils.SourceContent'] and parameter[2][@type='boolean']]"
		[Register ("onPos", "(Lcom/liveperson/infra/utils/SourceContent;Z)V", "GetOnPos_Lcom_liveperson_infra_utils_SourceContent_ZHandler:Com.Liveperson.Infra.Utils.ILinkPreviewCallbackInvoker, LP_Binding1_JustLP")]
		void OnPos (global::Com.Liveperson.Infra.Utils.SourceContent p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/interface[@name='LinkPreviewCallback']/method[@name='onPre' and count(parameter)=0]"
		[Register ("onPre", "()V", "GetOnPreHandler:Com.Liveperson.Infra.Utils.ILinkPreviewCallbackInvoker, LP_Binding1_JustLP")]
		void OnPre ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/utils/LinkPreviewCallback", DoNotGenerateAcw=true)]
	internal class ILinkPreviewCallbackInvoker : global::Java.Lang.Object, ILinkPreviewCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/utils/LinkPreviewCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILinkPreviewCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ILinkPreviewCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILinkPreviewCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.utils.LinkPreviewCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILinkPreviewCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clean;
#pragma warning disable 0169
		static Delegate GetCleanHandler ()
		{
			if (cb_clean == null)
				cb_clean = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clean);
			return cb_clean;
		}

		static void n_Clean (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clean ();
		}
#pragma warning restore 0169

		IntPtr id_clean;
		public unsafe void Clean ()
		{
			if (id_clean == IntPtr.Zero)
				id_clean = JNIEnv.GetMethodID (class_ref, "clean", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clean);
		}

		static Delegate cb_onPos_Lcom_liveperson_infra_utils_SourceContent_Z;
#pragma warning disable 0169
		static Delegate GetOnPos_Lcom_liveperson_infra_utils_SourceContent_ZHandler ()
		{
			if (cb_onPos_Lcom_liveperson_infra_utils_SourceContent_Z == null)
				cb_onPos_Lcom_liveperson_infra_utils_SourceContent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnPos_Lcom_liveperson_infra_utils_SourceContent_Z);
			return cb_onPos_Lcom_liveperson_infra_utils_SourceContent_Z;
		}

		static void n_OnPos_Lcom_liveperson_infra_utils_SourceContent_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.SourceContent p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.SourceContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPos (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPos_Lcom_liveperson_infra_utils_SourceContent_Z;
		public unsafe void OnPos (global::Com.Liveperson.Infra.Utils.SourceContent p0, bool p1)
		{
			if (id_onPos_Lcom_liveperson_infra_utils_SourceContent_Z == IntPtr.Zero)
				id_onPos_Lcom_liveperson_infra_utils_SourceContent_Z = JNIEnv.GetMethodID (class_ref, "onPos", "(Lcom/liveperson/infra/utils/SourceContent;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPos_Lcom_liveperson_infra_utils_SourceContent_Z, __args);
		}

		static Delegate cb_onPre;
#pragma warning disable 0169
		static Delegate GetOnPreHandler ()
		{
			if (cb_onPre == null)
				cb_onPre = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPre);
			return cb_onPre;
		}

		static void n_OnPre (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.ILinkPreviewCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPre ();
		}
#pragma warning restore 0169

		IntPtr id_onPre;
		public unsafe void OnPre ()
		{
			if (id_onPre == IntPtr.Zero)
				id_onPre = JNIEnv.GetMethodID (class_ref, "onPre", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPre);
		}

	}

}
