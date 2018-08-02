using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='UploadImageTaskBundle']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle", DoNotGenerateAcw=true)]
	public partial class UploadImageTaskBundle : global::Com.Liveperson.Messaging.Background.Filesharing.UploadFileTaskBundle {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UploadImageTaskBundle); }
		}

		protected UploadImageTaskBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='UploadImageTaskBundle']/constructor[@name='UploadImageTaskBundle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UploadImageTaskBundle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UploadImageTaskBundle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_isImageFromCamera;
#pragma warning disable 0169
		static Delegate GetIsImageFromCameraHandler ()
		{
			if (cb_isImageFromCamera == null)
				cb_isImageFromCamera = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsImageFromCamera);
			return cb_isImageFromCamera;
		}

		static bool n_IsImageFromCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsImageFromCamera;
		}
#pragma warning restore 0169

		static IntPtr id_isImageFromCamera;
		public virtual unsafe bool IsImageFromCamera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='UploadImageTaskBundle']/method[@name='isImageFromCamera' and count(parameter)=0]"
			[Register ("isImageFromCamera", "()Z", "GetIsImageFromCameraHandler")]
			get {
				if (id_isImageFromCamera == IntPtr.Zero)
					id_isImageFromCamera = JNIEnv.GetMethodID (class_ref, "isImageFromCamera", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isImageFromCamera);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isImageFromCamera", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addImageFromCamera_Z;
#pragma warning disable 0169
		static Delegate GetAddImageFromCamera_ZHandler ()
		{
			if (cb_addImageFromCamera_Z == null)
				cb_addImageFromCamera_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_AddImageFromCamera_Z);
			return cb_addImageFromCamera_Z;
		}

		static IntPtr n_AddImageFromCamera_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddImageFromCamera (p0));
		}
#pragma warning restore 0169

		static IntPtr id_addImageFromCamera_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='UploadImageTaskBundle']/method[@name='addImageFromCamera' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("addImageFromCamera", "(Z)Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;", "GetAddImageFromCamera_ZHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle AddImageFromCamera (bool p0)
		{
			if (id_addImageFromCamera_Z == IntPtr.Zero)
				id_addImageFromCamera_Z = JNIEnv.GetMethodID (class_ref, "addImageFromCamera", "(Z)Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addImageFromCamera_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addImageFromCamera", "(Z)Lcom/liveperson/messaging/background/filesharing/image/UploadImageTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
