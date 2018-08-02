using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Request.Message {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.api.request.message']/interface[@name='PublishMessage']"
	[Register ("com/liveperson/api/request/message/PublishMessage", "", "Com.Liveperson.Api.Request.Message.IPublishMessageInvoker")]
	public partial interface IPublishMessage : IJavaObject {

		global::Java.Lang.Object Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/interface[@name='PublishMessage']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/Object;", "GetGetMessageHandler:Com.Liveperson.Api.Request.Message.IPublishMessageInvoker, LP_Messaging_Binding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/liveperson/api/request/message/PublishMessage", DoNotGenerateAcw=true)]
	internal class IPublishMessageInvoker : global::Java.Lang.Object, IPublishMessage {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/api/request/message/PublishMessage");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPublishMessageInvoker); }
		}

		IntPtr class_ref;

		public static IPublishMessage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPublishMessage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.api.request.message.PublishMessage"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPublishMessageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Api.Request.Message.IPublishMessage __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Request.Message.IPublishMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public unsafe global::Java.Lang.Object Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
