using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/interface[@name='AmsViewHolder']"
	[Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsViewHolder", "", "Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolderInvoker")]
	public partial interface IAmsViewHolder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/interface[@name='AmsViewHolder']/method[@name='applyColors' and count(parameter)=0]"
		[Register ("applyColors", "()V", "GetApplyColorsHandler:Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolderInvoker, LP_MessagingUI_binding")]
		void ApplyColors ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter.viewholder']/interface[@name='AmsViewHolder']/method[@name='updateContentDescription' and count(parameter)=0]"
		[Register ("updateContentDescription", "()V", "GetUpdateContentDescriptionHandler:Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolderInvoker, LP_MessagingUI_binding")]
		void UpdateContentDescription ();

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsViewHolder", DoNotGenerateAcw=true)]
	internal class IAmsViewHolderInvoker : global::Java.Lang.Object, IAmsViewHolder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/viewholder/AmsViewHolder");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAmsViewHolderInvoker); }
		}

		IntPtr class_ref;

		public static IAmsViewHolder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAmsViewHolder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.view.adapter.viewholder.AmsViewHolder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAmsViewHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyColors;
#pragma warning disable 0169
		static Delegate GetApplyColorsHandler ()
		{
			if (cb_applyColors == null)
				cb_applyColors = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ApplyColors);
			return cb_applyColors;
		}

		static void n_ApplyColors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyColors ();
		}
#pragma warning restore 0169

		IntPtr id_applyColors;
		public unsafe void ApplyColors ()
		{
			if (id_applyColors == IntPtr.Zero)
				id_applyColors = JNIEnv.GetMethodID (class_ref, "applyColors", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyColors);
		}

		static Delegate cb_updateContentDescription;
#pragma warning disable 0169
		static Delegate GetUpdateContentDescriptionHandler ()
		{
			if (cb_updateContentDescription == null)
				cb_updateContentDescription = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateContentDescription);
			return cb_updateContentDescription;
		}

		static void n_UpdateContentDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Viewholder.IAmsViewHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateContentDescription ();
		}
#pragma warning restore 0169

		IntPtr id_updateContentDescription;
		public unsafe void UpdateContentDescription ()
		{
			if (id_updateContentDescription == IntPtr.Zero)
				id_updateContentDescription = JNIEnv.GetMethodID (class_ref, "updateContentDescription", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateContentDescription);
		}

	}

}
