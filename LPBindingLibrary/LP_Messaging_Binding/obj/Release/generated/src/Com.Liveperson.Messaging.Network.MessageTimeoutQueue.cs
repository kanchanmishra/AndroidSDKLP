using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/MessageTimeoutQueue", DoNotGenerateAcw=true)]
	public partial class MessageTimeoutQueue : global::Java.Lang.Object, global::Com.Liveperson.Infra.Utils.IHandleMessageCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue.BrandConversationObj']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/network/MessageTimeoutQueue$BrandConversationObj", DoNotGenerateAcw=true)]
		public partial class BrandConversationObj : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/network/MessageTimeoutQueue$BrandConversationObj", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BrandConversationObj); }
			}

			protected BrandConversationObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue.BrandConversationObj']/constructor[@name='MessageTimeoutQueue.BrandConversationObj' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.network.MessageTimeoutQueue.MessageType'] and parameter[4][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;Ljava/lang/String;)V", "")]
			public unsafe BrandConversationObj (string p0, string p1, global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p2, string p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (native_p3);
					if (((object) this).GetType () != typeof (BrandConversationObj)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue.MessageType']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/network/MessageTimeoutQueue$MessageType", DoNotGenerateAcw=true)]
		public sealed partial class MessageType : global::Java.Lang.Enum {


			static IntPtr KEEP_ALIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue.MessageType']/field[@name='KEEP_ALIVE']"
			[Register ("KEEP_ALIVE")]
			public static global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType KeepAlive {
				get {
					if (KEEP_ALIVE_jfieldId == IntPtr.Zero)
						KEEP_ALIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KEEP_ALIVE", "Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KEEP_ALIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PUBLISH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue.MessageType']/field[@name='PUBLISH']"
			[Register ("PUBLISH")]
			public static global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType Publish {
				get {
					if (PUBLISH_jfieldId == IntPtr.Zero)
						PUBLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLISH", "Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUBLISH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/network/MessageTimeoutQueue$MessageType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MessageType); }
			}

			internal MessageType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue.MessageType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue.MessageType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;");
				try {
					return (global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/MessageTimeoutQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageTimeoutQueue); }
		}

		protected MessageTimeoutQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_network_http_MessageTimeoutListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']/constructor[@name='MessageTimeoutQueue' and count(parameter)=1 and parameter[1][@type='com.liveperson.messaging.network.http.MessageTimeoutListener']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/network/http/MessageTimeoutListener;)V", "")]
		public unsafe MessageTimeoutQueue (global::Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListener p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MessageTimeoutQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/network/http/MessageTimeoutListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/network/http/MessageTimeoutListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_network_http_MessageTimeoutListener_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_network_http_MessageTimeoutListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/network/http/MessageTimeoutListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_network_http_MessageTimeoutListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_network_http_MessageTimeoutListener_, __args);
			} finally {
			}
		}

		static Delegate cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I == null)
				cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_Add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I);
			return cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I;
		}

		static void n_Add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, int p4)
		{
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']/method[@name='add' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.network.MessageTimeoutQueue.MessageType'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;I)V", "GetAdd_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe void Add (global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p0, int p1, string p2, string p3, int p4)
		{
			if (id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']/method[@name='add' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.network.MessageTimeoutQueue.MessageType'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetAdd_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Add (global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p0, int p1, string p2, string p3, string p4)
		{
			if (id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int>) n_Add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I);
			return cb_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_Add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5)
		{
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']/method[@name='add' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.network.MessageTimeoutQueue.MessageType'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int']]"
		[Register ("add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "GetAdd_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public virtual unsafe void Add (global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p0, int p1, string p2, string p3, string p4, int p5)
		{
			if (id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_handleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_handleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_handleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_HandleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_handleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_HandleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.HandleMsgImmediately (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_handleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']/method[@name='handleMsgImmediately' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.network.MessageTimeoutQueue.MessageType'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("handleMsgImmediately", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetHandleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void HandleMsgImmediately (global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue.MessageType p0, int p1, string p2, string p3, string p4)
		{
			if (id_handleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_handleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleMsgImmediately", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleMsgImmediately_Lcom_liveperson_messaging_network_MessageTimeoutQueue_MessageType_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleMsgImmediately", "(Lcom/liveperson/messaging/network/MessageTimeoutQueue$MessageType;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_onHandleMessage_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetOnHandleMessage_Landroid_os_Message_Handler ()
		{
			if (cb_onHandleMessage_Landroid_os_Message_ == null)
				cb_onHandleMessage_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandleMessage_Landroid_os_Message_);
			return cb_onHandleMessage_Landroid_os_Message_;
		}

		static void n_OnHandleMessage_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Message p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHandleMessage_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']/method[@name='onHandleMessage' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("onHandleMessage", "(Landroid/os/Message;)V", "GetOnHandleMessage_Landroid_os_Message_Handler")]
		public virtual unsafe void OnHandleMessage (global::Android.OS.Message p0)
		{
			if (id_onHandleMessage_Landroid_os_Message_ == IntPtr.Zero)
				id_onHandleMessage_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "onHandleMessage", "(Landroid/os/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHandleMessage_Landroid_os_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandleMessage", "(Landroid/os/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Remove_I);
			return cb_remove_I;
		}

		static bool n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Z", "GetRemove_IHandler")]
		public virtual unsafe bool Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_removeAll;
#pragma warning disable 0169
		static Delegate GetRemoveAllHandler ()
		{
			if (cb_removeAll == null)
				cb_removeAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAll);
			return cb_removeAll;
		}

		static void n_RemoveAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.MessageTimeoutQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network']/class[@name='MessageTimeoutQueue']/method[@name='removeAll' and count(parameter)=0]"
		[Register ("removeAll", "()V", "GetRemoveAllHandler")]
		public virtual unsafe void RemoveAll ()
		{
			if (id_removeAll == IntPtr.Zero)
				id_removeAll = JNIEnv.GetMethodID (class_ref, "removeAll", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAll);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAll", "()V"));
			} finally {
			}
		}

	}
}
