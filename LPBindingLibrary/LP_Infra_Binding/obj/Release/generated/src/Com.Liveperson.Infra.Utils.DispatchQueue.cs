using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/DispatchQueue", DoNotGenerateAcw=true)]
	public partial class DispatchQueue : global::Android.OS.HandlerThread, global::Android.OS.MessageQueue.IIdleHandler, global::Com.Liveperson.Infra.IDisposable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue.DispatchQueueHandler']"
		[global::Android.Runtime.Register ("com/liveperson/infra/utils/DispatchQueue$DispatchQueueHandler", DoNotGenerateAcw=true)]
		public partial class DispatchQueueHandler : global::Android.OS.Handler {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/utils/DispatchQueue$DispatchQueueHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DispatchQueueHandler); }
			}

			protected DispatchQueueHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_os_Looper_Lcom_liveperson_infra_utils_DispatchQueue_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue.DispatchQueueHandler']/constructor[@name='DispatchQueue.DispatchQueueHandler' and count(parameter)=2 and parameter[1][@type='android.os.Looper'] and parameter[2][@type='com.liveperson.infra.utils.DispatchQueue']]"
			[Register (".ctor", "(Landroid/os/Looper;Lcom/liveperson/infra/utils/DispatchQueue;)V", "")]
			public unsafe DispatchQueueHandler (global::Android.OS.Looper p0, global::Com.Liveperson.Infra.Utils.DispatchQueue p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (DispatchQueueHandler)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Looper;Lcom/liveperson/infra/utils/DispatchQueue;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Looper;Lcom/liveperson/infra/utils/DispatchQueue;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Looper_Lcom_liveperson_infra_utils_DispatchQueue_ == IntPtr.Zero)
						id_ctor_Landroid_os_Looper_Lcom_liveperson_infra_utils_DispatchQueue_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Looper;Lcom/liveperson/infra/utils/DispatchQueue;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Looper_Lcom_liveperson_infra_utils_DispatchQueue_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Looper_Lcom_liveperson_infra_utils_DispatchQueue_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/DispatchQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DispatchQueue); }
		}

		protected DispatchQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ILcom_liveperson_infra_network_socket_IdleQueueHandler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/constructor[@name='DispatchQueue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='com.liveperson.infra.network.socket.IdleQueueHandler']]"
		[Register (".ctor", "(Ljava/lang/String;ILcom/liveperson/infra/network/socket/IdleQueueHandler;)V", "")]
		public unsafe DispatchQueue (string p0, int p1, global::Com.Liveperson.Infra.Network.Socket.IIdleQueueHandler p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (DispatchQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;ILcom/liveperson/infra/network/socket/IdleQueueHandler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;ILcom/liveperson/infra/network/socket/IdleQueueHandler;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ILcom_liveperson_infra_network_socket_IdleQueueHandler_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ILcom_liveperson_infra_network_socket_IdleQueueHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILcom/liveperson/infra/network/socket/IdleQueueHandler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILcom_liveperson_infra_network_socket_IdleQueueHandler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_ILcom_liveperson_infra_network_socket_IdleQueueHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_socket_IdleQueueHandler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/constructor[@name='DispatchQueue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.network.socket.IdleQueueHandler']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/IdleQueueHandler;)V", "")]
		public unsafe DispatchQueue (string p0, global::Com.Liveperson.Infra.Network.Socket.IIdleQueueHandler p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (DispatchQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/IdleQueueHandler;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/IdleQueueHandler;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_socket_IdleQueueHandler_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_socket_IdleQueueHandler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/liveperson/infra/network/socket/IdleQueueHandler;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_socket_IdleQueueHandler_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_liveperson_infra_network_socket_IdleQueueHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/constructor[@name='DispatchQueue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe DispatchQueue (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (DispatchQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/constructor[@name='DispatchQueue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DispatchQueue (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (DispatchQueue)) {
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

		static Delegate cb_isCurrentThread;
#pragma warning disable 0169
		static Delegate GetIsCurrentThreadHandler ()
		{
			if (cb_isCurrentThread == null)
				cb_isCurrentThread = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurrentThread);
			return cb_isCurrentThread;
		}

		static bool n_IsCurrentThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentThread;
		}
#pragma warning restore 0169

		static IntPtr id_isCurrentThread;
		public virtual unsafe bool IsCurrentThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='isCurrentThread' and count(parameter)=0]"
			[Register ("isCurrentThread", "()Z", "GetIsCurrentThreadHandler")]
			get {
				if (id_isCurrentThread == IntPtr.Zero)
					id_isCurrentThread = JNIEnv.GetMethodID (class_ref, "isCurrentThread", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentThread);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCurrentThread", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cleanupQueue;
#pragma warning disable 0169
		static Delegate GetCleanupQueueHandler ()
		{
			if (cb_cleanupQueue == null)
				cb_cleanupQueue = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CleanupQueue);
			return cb_cleanupQueue;
		}

		static void n_CleanupQueue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanupQueue ();
		}
#pragma warning restore 0169

		static IntPtr id_cleanupQueue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='cleanupQueue' and count(parameter)=0]"
		[Register ("cleanupQueue", "()V", "GetCleanupQueueHandler")]
		public virtual unsafe void CleanupQueue ()
		{
			if (id_cleanupQueue == IntPtr.Zero)
				id_cleanupQueue = JNIEnv.GetMethodID (class_ref, "cleanupQueue", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cleanupQueue);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cleanupQueue", "()V"));
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

		static Delegate cb_postRunnable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetPostRunnable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_postRunnable_Ljava_lang_Runnable_ == null)
				cb_postRunnable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostRunnable_Ljava_lang_Runnable_);
			return cb_postRunnable_Ljava_lang_Runnable_;
		}

		static void n_PostRunnable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostRunnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_postRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='postRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("postRunnable", "(Ljava/lang/Runnable;)V", "GetPostRunnable_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void PostRunnable (global::Java.Lang.IRunnable p0)
		{
			if (id_postRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_postRunnable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "postRunnable", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postRunnable_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postRunnable", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_postRunnable_Ljava_lang_Runnable_J;
#pragma warning disable 0169
		static Delegate GetPostRunnable_Ljava_lang_Runnable_JHandler ()
		{
			if (cb_postRunnable_Ljava_lang_Runnable_J == null)
				cb_postRunnable_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_PostRunnable_Ljava_lang_Runnable_J);
			return cb_postRunnable_Ljava_lang_Runnable_J;
		}

		static void n_PostRunnable_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PostRunnable (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_postRunnable_Ljava_lang_Runnable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='postRunnable' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
		[Register ("postRunnable", "(Ljava/lang/Runnable;J)V", "GetPostRunnable_Ljava_lang_Runnable_JHandler")]
		public virtual unsafe void PostRunnable (global::Java.Lang.IRunnable p0, long p1)
		{
			if (id_postRunnable_Ljava_lang_Runnable_J == IntPtr.Zero)
				id_postRunnable_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "postRunnable", "(Ljava/lang/Runnable;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postRunnable_Ljava_lang_Runnable_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postRunnable", "(Ljava/lang/Runnable;J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_queueIdle;
#pragma warning disable 0169
		static Delegate GetQueueIdleHandler ()
		{
			if (cb_queueIdle == null)
				cb_queueIdle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_QueueIdle);
			return cb_queueIdle;
		}

		static bool n_QueueIdle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.QueueIdle ();
		}
#pragma warning restore 0169

		static IntPtr id_queueIdle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='queueIdle' and count(parameter)=0]"
		[Register ("queueIdle", "()Z", "GetQueueIdleHandler")]
		public virtual unsafe bool QueueIdle ()
		{
			if (id_queueIdle == IntPtr.Zero)
				id_queueIdle = JNIEnv.GetMethodID (class_ref, "queueIdle", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_queueIdle);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "queueIdle", "()Z"));
			} finally {
			}
		}

		static Delegate cb_removeMessage_I;
#pragma warning disable 0169
		static Delegate GetRemoveMessage_IHandler ()
		{
			if (cb_removeMessage_I == null)
				cb_removeMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RemoveMessage_I);
			return cb_removeMessage_I;
		}

		static bool n_RemoveMessage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='removeMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeMessage", "(I)Z", "GetRemoveMessage_IHandler")]
		public virtual unsafe bool RemoveMessage (int p0)
		{
			if (id_removeMessage_I == IntPtr.Zero)
				id_removeMessage_I = JNIEnv.GetMethodID (class_ref, "removeMessage", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeMessage_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMessage", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_removeRunnable_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRemoveRunnable_Ljava_lang_Runnable_Handler ()
		{
			if (cb_removeRunnable_Ljava_lang_Runnable_ == null)
				cb_removeRunnable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveRunnable_Ljava_lang_Runnable_);
			return cb_removeRunnable_Ljava_lang_Runnable_;
		}

		static void n_RemoveRunnable_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRunnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeRunnable_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='removeRunnable' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("removeRunnable", "(Ljava/lang/Runnable;)V", "GetRemoveRunnable_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void RemoveRunnable (global::Java.Lang.IRunnable p0)
		{
			if (id_removeRunnable_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_removeRunnable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "removeRunnable", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeRunnable_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeRunnable", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Landroid_os_Message_Handler ()
		{
			if (cb_sendMessage_Landroid_os_Message_ == null)
				cb_sendMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendMessage_Landroid_os_Message_);
			return cb_sendMessage_Landroid_os_Message_;
		}

		static void n_SendMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("sendMessage", "(Landroid/os/Message;)V", "GetSendMessage_Landroid_os_Message_Handler")]
		public virtual unsafe void SendMessage (global::Android.OS.Message p0)
		{
			if (id_sendMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_sendMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Landroid/os/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Landroid_os_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Landroid/os/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMessage_Landroid_os_Message_I;
#pragma warning disable 0169
		static Delegate GetSendMessage_Landroid_os_Message_IHandler ()
		{
			if (cb_sendMessage_Landroid_os_Message_I == null)
				cb_sendMessage_Landroid_os_Message_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SendMessage_Landroid_os_Message_I);
			return cb_sendMessage_Landroid_os_Message_I;
		}

		static void n_SendMessage_Landroid_os_Message_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Landroid_os_Message_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='android.os.Message'] and parameter[2][@type='int']]"
		[Register ("sendMessage", "(Landroid/os/Message;I)V", "GetSendMessage_Landroid_os_Message_IHandler")]
		public virtual unsafe void SendMessage (global::Android.OS.Message p0, int p1)
		{
			if (id_sendMessage_Landroid_os_Message_I == IntPtr.Zero)
				id_sendMessage_Landroid_os_Message_I = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Landroid/os/Message;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Landroid_os_Message_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Landroid/os/Message;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_;
#pragma warning disable 0169
		static Delegate GetSetHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_Handler ()
		{
			if (cb_setHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_ == null)
				cb_setHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_);
			return cb_setHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_;
		}

		static void n_SetHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Utils.IHandleMessageCallback p0 = (global::Com.Liveperson.Infra.Utils.IHandleMessageCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.IHandleMessageCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHandleMessageCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='setHandleMessageCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.utils.HandleMessageCallback']]"
		[Register ("setHandleMessageCallback", "(Lcom/liveperson/infra/utils/HandleMessageCallback;)V", "GetSetHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_Handler")]
		public virtual unsafe void SetHandleMessageCallback (global::Com.Liveperson.Infra.Utils.IHandleMessageCallback p0)
		{
			if (id_setHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_ == IntPtr.Zero)
				id_setHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_ = JNIEnv.GetMethodID (class_ref, "setHandleMessageCallback", "(Lcom/liveperson/infra/utils/HandleMessageCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHandleMessageCallback_Lcom_liveperson_infra_utils_HandleMessageCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHandleMessageCallback", "(Lcom/liveperson/infra/utils/HandleMessageCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregisterQueueIdleCallbacks;
#pragma warning disable 0169
		static Delegate GetUnregisterQueueIdleCallbacksHandler ()
		{
			if (cb_unregisterQueueIdleCallbacks == null)
				cb_unregisterQueueIdleCallbacks = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterQueueIdleCallbacks);
			return cb_unregisterQueueIdleCallbacks;
		}

		static void n_UnregisterQueueIdleCallbacks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Utils.DispatchQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.DispatchQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterQueueIdleCallbacks ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterQueueIdleCallbacks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DispatchQueue']/method[@name='unregisterQueueIdleCallbacks' and count(parameter)=0]"
		[Register ("unregisterQueueIdleCallbacks", "()V", "GetUnregisterQueueIdleCallbacksHandler")]
		public virtual unsafe void UnregisterQueueIdleCallbacks ()
		{
			if (id_unregisterQueueIdleCallbacks == IntPtr.Zero)
				id_unregisterQueueIdleCallbacks = JNIEnv.GetMethodID (class_ref, "unregisterQueueIdleCallbacks", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterQueueIdleCallbacks);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterQueueIdleCallbacks", "()V"));
			} finally {
			}
		}

	}
}
