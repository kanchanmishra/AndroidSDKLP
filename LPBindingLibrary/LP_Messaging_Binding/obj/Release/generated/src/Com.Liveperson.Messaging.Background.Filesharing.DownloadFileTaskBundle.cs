using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/DownloadFileTaskBundle", DoNotGenerateAcw=true)]
	public partial class DownloadFileTaskBundle : global::Com.Liveperson.Messaging.Background.Filesharing.BaseTaskBundle {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/DownloadFileTaskBundle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadFileTaskBundle); }
		}

		protected DownloadFileTaskBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/constructor[@name='DownloadFileTaskBundle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DownloadFileTaskBundle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DownloadFileTaskBundle)) {
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

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFileRowId;
#pragma warning disable 0169
		static Delegate GetGetFileRowIdHandler ()
		{
			if (cb_getFileRowId == null)
				cb_getFileRowId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetFileRowId);
			return cb_getFileRowId;
		}

		static long n_GetFileRowId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileRowId;
		}
#pragma warning restore 0169

		static IntPtr id_getFileRowId;
		public virtual unsafe long FileRowId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='getFileRowId' and count(parameter)=0]"
			[Register ("getFileRowId", "()J", "GetGetFileRowIdHandler")]
			get {
				if (id_getFileRowId == IntPtr.Zero)
					id_getFileRowId = JNIEnv.GetMethodID (class_ref, "getFileRowId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getFileRowId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileRowId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessageRowId;
#pragma warning disable 0169
		static Delegate GetGetMessageRowIdHandler ()
		{
			if (cb_getMessageRowId == null)
				cb_getMessageRowId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMessageRowId);
			return cb_getMessageRowId;
		}

		static long n_GetMessageRowId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageRowId;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageRowId;
		public virtual unsafe long MessageRowId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='getMessageRowId' and count(parameter)=0]"
			[Register ("getMessageRowId", "()J", "GetGetMessageRowIdHandler")]
			get {
				if (id_getMessageRowId == IntPtr.Zero)
					id_getMessageRowId = JNIEnv.GetMethodID (class_ref, "getMessageRowId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMessageRowId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageRowId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getRelativePath;
#pragma warning disable 0169
		static Delegate GetGetRelativePathHandler ()
		{
			if (cb_getRelativePath == null)
				cb_getRelativePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRelativePath);
			return cb_getRelativePath;
		}

		static IntPtr n_GetRelativePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RelativePath);
		}
#pragma warning restore 0169

		static IntPtr id_getRelativePath;
		public virtual unsafe string RelativePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='getRelativePath' and count(parameter)=0]"
			[Register ("getRelativePath", "()Ljava/lang/String;", "GetGetRelativePathHandler")]
			get {
				if (id_getRelativePath == IntPtr.Zero)
					id_getRelativePath = JNIEnv.GetMethodID (class_ref, "getRelativePath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRelativePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelativePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRestParams;
#pragma warning disable 0169
		static Delegate GetGetRestParamsHandler ()
		{
			if (cb_getRestParams == null)
				cb_getRestParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRestParams);
			return cb_getRestParams;
		}

		static IntPtr n_GetRestParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RestParams);
		}
#pragma warning restore 0169

		static IntPtr id_getRestParams;
		public virtual unsafe global::Com.Liveperson.Messaging.Network.Http.RestRequestParams RestParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='getRestParams' and count(parameter)=0]"
			[Register ("getRestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;", "GetGetRestParamsHandler")]
			get {
				if (id_getRestParams == IntPtr.Zero)
					id_getRestParams = JNIEnv.GetMethodID (class_ref, "getRestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRestParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRestParams", "()Lcom/liveperson/messaging/network/http/RestRequestParams;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addFileRowId_J;
#pragma warning disable 0169
		static Delegate GetAddFileRowId_JHandler ()
		{
			if (cb_addFileRowId_J == null)
				cb_addFileRowId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_AddFileRowId_J);
			return cb_addFileRowId_J;
		}

		static IntPtr n_AddFileRowId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddFileRowId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_addFileRowId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='addFileRowId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("addFileRowId", "(J)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;", "GetAddFileRowId_JHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle AddFileRowId (long p0)
		{
			if (id_addFileRowId_J == IntPtr.Zero)
				id_addFileRowId_J = JNIEnv.GetMethodID (class_ref, "addFileRowId", "(J)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addFileRowId_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFileRowId", "(J)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addMessageRowId_J;
#pragma warning disable 0169
		static Delegate GetAddMessageRowId_JHandler ()
		{
			if (cb_addMessageRowId_J == null)
				cb_addMessageRowId_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_AddMessageRowId_J);
			return cb_addMessageRowId_J;
		}

		static IntPtr n_AddMessageRowId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddMessageRowId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_addMessageRowId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='addMessageRowId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("addMessageRowId", "(J)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;", "GetAddMessageRowId_JHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle AddMessageRowId (long p0)
		{
			if (id_addMessageRowId_J == IntPtr.Zero)
				id_addMessageRowId_J = JNIEnv.GetMethodID (class_ref, "addMessageRowId", "(J)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMessageRowId_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMessageRowId", "(J)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addRelativePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddRelativePath_Ljava_lang_String_Handler ()
		{
			if (cb_addRelativePath_Ljava_lang_String_ == null)
				cb_addRelativePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddRelativePath_Ljava_lang_String_);
			return cb_addRelativePath_Ljava_lang_String_;
		}

		static IntPtr n_AddRelativePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddRelativePath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addRelativePath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='addRelativePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addRelativePath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;", "GetAddRelativePath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle AddRelativePath (string p0)
		{
			if (id_addRelativePath_Ljava_lang_String_ == IntPtr.Zero)
				id_addRelativePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addRelativePath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addRelativePath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRelativePath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_build_JLandroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetBuild_JLandroid_content_Context_Handler ()
		{
			if (cb_build_JLandroid_content_Context_ == null)
				cb_build_JLandroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Build_JLandroid_content_Context_);
			return cb_build_JLandroid_content_Context_;
		}

		static IntPtr n_Build_JLandroid_content_Context_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_build_JLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing']/class[@name='DownloadFileTaskBundle']/method[@name='build' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='android.content.Context']]"
		[Register ("build", "(JLandroid/content/Context;)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;", "GetBuild_JLandroid_content_Context_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle Build (long p0, global::Android.Content.Context p1)
		{
			if (id_build_JLandroid_content_Context_ == IntPtr.Zero)
				id_build_JLandroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "build", "(JLandroid/content/Context;)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build_JLandroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.DownloadFileTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(JLandroid/content/Context;)Lcom/liveperson/messaging/background/filesharing/DownloadFileTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
