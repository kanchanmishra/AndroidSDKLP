using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Background.Filesharing.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle", DoNotGenerateAcw=true)]
	public partial class ReUploadImageTaskBundle : global::Com.Liveperson.Messaging.Background.Filesharing.Image.UploadImageTaskBundle {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReUploadImageTaskBundle); }
		}

		protected ReUploadImageTaskBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/constructor[@name='ReUploadImageTaskBundle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ReUploadImageTaskBundle ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ReUploadImageTaskBundle)) {
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

		static Delegate cb_getEventId;
#pragma warning disable 0169
		static Delegate GetGetEventIdHandler ()
		{
			if (cb_getEventId == null)
				cb_getEventId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventId);
			return cb_getEventId;
		}

		static IntPtr n_GetEventId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventId);
		}
#pragma warning restore 0169

		static IntPtr id_getEventId;
		public virtual unsafe string EventId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='getEventId' and count(parameter)=0]"
			[Register ("getEventId", "()Ljava/lang/String;", "GetGetEventIdHandler")]
			get {
				if (id_getEventId == IntPtr.Zero)
					id_getEventId = JNIEnv.GetMethodID (class_ref, "getEventId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FileRowId;
		}
#pragma warning restore 0169

		static IntPtr id_getFileRowId;
		public virtual unsafe long FileRowId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='getFileRowId' and count(parameter)=0]"
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

		static Delegate cb_getOriginalMessageTime;
#pragma warning disable 0169
		static Delegate GetGetOriginalMessageTimeHandler ()
		{
			if (cb_getOriginalMessageTime == null)
				cb_getOriginalMessageTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOriginalMessageTime);
			return cb_getOriginalMessageTime;
		}

		static long n_GetOriginalMessageTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OriginalMessageTime;
		}
#pragma warning restore 0169

		static IntPtr id_getOriginalMessageTime;
		public virtual unsafe long OriginalMessageTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='getOriginalMessageTime' and count(parameter)=0]"
			[Register ("getOriginalMessageTime", "()J", "GetGetOriginalMessageTimeHandler")]
			get {
				if (id_getOriginalMessageTime == IntPtr.Zero)
					id_getOriginalMessageTime = JNIEnv.GetMethodID (class_ref, "getOriginalMessageTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getOriginalMessageTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOriginalMessageTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getThumbnailLocalPath;
#pragma warning disable 0169
		static Delegate GetGetThumbnailLocalPathHandler ()
		{
			if (cb_getThumbnailLocalPath == null)
				cb_getThumbnailLocalPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThumbnailLocalPath);
			return cb_getThumbnailLocalPath;
		}

		static IntPtr n_GetThumbnailLocalPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThumbnailLocalPath);
		}
#pragma warning restore 0169

		static IntPtr id_getThumbnailLocalPath;
		public virtual unsafe string ThumbnailLocalPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='getThumbnailLocalPath' and count(parameter)=0]"
			[Register ("getThumbnailLocalPath", "()Ljava/lang/String;", "GetGetThumbnailLocalPathHandler")]
			get {
				if (id_getThumbnailLocalPath == IntPtr.Zero)
					id_getThumbnailLocalPath = JNIEnv.GetMethodID (class_ref, "getThumbnailLocalPath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThumbnailLocalPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThumbnailLocalPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addEventID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddEventID_Ljava_lang_String_Handler ()
		{
			if (cb_addEventID_Ljava_lang_String_ == null)
				cb_addEventID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddEventID_Ljava_lang_String_);
			return cb_addEventID_Ljava_lang_String_;
		}

		static IntPtr n_AddEventID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddEventID (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addEventID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='addEventID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addEventID", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;", "GetAddEventID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle AddEventID (string p0)
		{
			if (id_addEventID_Ljava_lang_String_ == IntPtr.Zero)
				id_addEventID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addEventID", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addEventID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEventID", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddFileRowId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_addFileRowId_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='addFileRowId' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("addFileRowId", "(J)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;", "GetAddFileRowId_JHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle AddFileRowId (long p0)
		{
			if (id_addFileRowId_J == IntPtr.Zero)
				id_addFileRowId_J = JNIEnv.GetMethodID (class_ref, "addFileRowId", "(J)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addFileRowId_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFileRowId", "(J)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addOriginalLocalPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddOriginalLocalPath_Ljava_lang_String_Handler ()
		{
			if (cb_addOriginalLocalPath_Ljava_lang_String_ == null)
				cb_addOriginalLocalPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddOriginalLocalPath_Ljava_lang_String_);
			return cb_addOriginalLocalPath_Ljava_lang_String_;
		}

		static IntPtr n_AddOriginalLocalPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOriginalLocalPath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addOriginalLocalPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='addOriginalLocalPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addOriginalLocalPath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;", "GetAddOriginalLocalPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle AddOriginalLocalPath (string p0)
		{
			if (id_addOriginalLocalPath_Ljava_lang_String_ == IntPtr.Zero)
				id_addOriginalLocalPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addOriginalLocalPath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addOriginalLocalPath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOriginalLocalPath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addOriginalMessageTime_J;
#pragma warning disable 0169
		static Delegate GetAddOriginalMessageTime_JHandler ()
		{
			if (cb_addOriginalMessageTime_J == null)
				cb_addOriginalMessageTime_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_AddOriginalMessageTime_J);
			return cb_addOriginalMessageTime_J;
		}

		static IntPtr n_AddOriginalMessageTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddOriginalMessageTime (p0));
		}
#pragma warning restore 0169

		static IntPtr id_addOriginalMessageTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='addOriginalMessageTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("addOriginalMessageTime", "(J)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;", "GetAddOriginalMessageTime_JHandler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle AddOriginalMessageTime (long p0)
		{
			if (id_addOriginalMessageTime_J == IntPtr.Zero)
				id_addOriginalMessageTime_J = JNIEnv.GetMethodID (class_ref, "addOriginalMessageTime", "(J)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addOriginalMessageTime_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOriginalMessageTime", "(J)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addThumbnailLocalPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddThumbnailLocalPath_Ljava_lang_String_Handler ()
		{
			if (cb_addThumbnailLocalPath_Ljava_lang_String_ == null)
				cb_addThumbnailLocalPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddThumbnailLocalPath_Ljava_lang_String_);
			return cb_addThumbnailLocalPath_Ljava_lang_String_;
		}

		static IntPtr n_AddThumbnailLocalPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddThumbnailLocalPath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addThumbnailLocalPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.background.filesharing.image']/class[@name='ReUploadImageTaskBundle']/method[@name='addThumbnailLocalPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addThumbnailLocalPath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;", "GetAddThumbnailLocalPath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle AddThumbnailLocalPath (string p0)
		{
			if (id_addThumbnailLocalPath_Ljava_lang_String_ == IntPtr.Zero)
				id_addThumbnailLocalPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addThumbnailLocalPath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addThumbnailLocalPath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.Image.ReUploadImageTaskBundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addThumbnailLocalPath", "(Ljava/lang/String;)Lcom/liveperson/messaging/background/filesharing/image/ReUploadImageTaskBundle;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
