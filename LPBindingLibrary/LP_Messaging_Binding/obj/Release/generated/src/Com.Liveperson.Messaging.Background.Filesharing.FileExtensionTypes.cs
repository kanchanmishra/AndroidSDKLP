using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileExtensionTypes']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/FileExtensionTypes", DoNotGenerateAcw=true)]
	public partial class FileExtensionTypes : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/FileExtensionTypes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileExtensionTypes); }
		}

		protected FileExtensionTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileExtensionTypes']/constructor[@name='FileExtensionTypes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileExtensionTypes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FileExtensionTypes)) {
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

		static IntPtr id_getImageExtensions;
		public static unsafe global::System.Collections.Generic.IList<string> ImageExtensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileExtensionTypes']/method[@name='getImageExtensions' and count(parameter)=0]"
			[Register ("getImageExtensions", "()Ljava/util/List;", "GetGetImageExtensionsHandler")]
			get {
				if (id_getImageExtensions == IntPtr.Zero)
					id_getImageExtensions = JNIEnv.GetStaticMethodID (class_ref, "getImageExtensions", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImageExtensions), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getImageExtensionsAsSqlString;
		public static unsafe string ImageExtensionsAsSqlString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileExtensionTypes']/method[@name='getImageExtensionsAsSqlString' and count(parameter)=0]"
			[Register ("getImageExtensionsAsSqlString", "()Ljava/lang/String;", "GetGetImageExtensionsAsSqlStringHandler")]
			get {
				if (id_getImageExtensionsAsSqlString == IntPtr.Zero)
					id_getImageExtensionsAsSqlString = JNIEnv.GetStaticMethodID (class_ref, "getImageExtensionsAsSqlString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImageExtensionsAsSqlString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVoiceExtensions;
		public static unsafe global::System.Collections.Generic.IList<string> VoiceExtensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileExtensionTypes']/method[@name='getVoiceExtensions' and count(parameter)=0]"
			[Register ("getVoiceExtensions", "()Ljava/util/List;", "GetGetVoiceExtensionsHandler")]
			get {
				if (id_getVoiceExtensions == IntPtr.Zero)
					id_getVoiceExtensions = JNIEnv.GetStaticMethodID (class_ref, "getVoiceExtensions", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVoiceExtensions), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getVoiceExtensionsAsSqlString;
		public static unsafe string VoiceExtensionsAsSqlString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='FileExtensionTypes']/method[@name='getVoiceExtensionsAsSqlString' and count(parameter)=0]"
			[Register ("getVoiceExtensionsAsSqlString", "()Ljava/lang/String;", "GetGetVoiceExtensionsAsSqlStringHandler")]
			get {
				if (id_getVoiceExtensionsAsSqlString == IntPtr.Zero)
					id_getVoiceExtensionsAsSqlString = JNIEnv.GetStaticMethodID (class_ref, "getVoiceExtensionsAsSqlString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getVoiceExtensionsAsSqlString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
