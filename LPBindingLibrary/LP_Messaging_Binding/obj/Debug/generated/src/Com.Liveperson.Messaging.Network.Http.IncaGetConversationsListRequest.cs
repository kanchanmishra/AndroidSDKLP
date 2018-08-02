using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/http/IncaGetConversationsListRequest", DoNotGenerateAcw=true)]
	public partial class IncaGetConversationsListRequest : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']/field[@name='MAX_LIMIT']"
		[Register ("MAX_LIMIT")]
		public const int MaxLimit = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']/field[@name='MAX_TIME_LIMIT']"
		[Register ("MAX_TIME_LIMIT")]
		public const long MaxTimeLimit = (long) 34070400000L;

		static IntPtr mController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']/field[@name='mController']"
		[Register ("mController")]
		protected global::Com.Liveperson.Messaging.Messaging MController {
			get {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mController_jfieldId == IntPtr.Zero)
					mController_jfieldId = JNIEnv.GetFieldID (class_ref, "mController", "Lcom/liveperson/messaging/Messaging;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/http/IncaGetConversationsListRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IncaGetConversationsListRequest); }
		}

		protected IncaGetConversationsListRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_JJJLcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']/constructor[@name='IncaGetConversationsListRequest' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.Messaging'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='com.liveperson.infra.ICallback&lt;java.util.ArrayList&lt;com.liveperson.api.response.model.ConversationINCADetails&gt;, java.lang.Exception&gt;']]"
		[Register (".ctor", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;JJJLcom/liveperson/infra/ICallback;)V", "")]
		public unsafe IncaGetConversationsListRequest (global::Com.Liveperson.Messaging.Messaging p0, string p1, long p2, long p3, long p4, global::Com.Liveperson.Infra.ICallback p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (IncaGetConversationsListRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;JJJLcom/liveperson/infra/ICallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;JJJLcom/liveperson/infra/ICallback;)V", __args);
					return;
				}

				if (id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_JJJLcom_liveperson_infra_ICallback_ == IntPtr.Zero)
					id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_JJJLcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/messaging/Messaging;Ljava/lang/String;JJJLcom/liveperson/infra/ICallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_JJJLcom_liveperson_infra_ICallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_messaging_Messaging_Ljava_lang_String_JJJLcom_liveperson_infra_ICallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOffset);
			return cb_getOffset;
		}

		static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Http.IncaGetConversationsListRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IncaGetConversationsListRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_J;
#pragma warning disable 0169
		static Delegate GetSetOffset_JHandler ()
		{
			if (cb_setOffset_J == null)
				cb_setOffset_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetOffset_J);
			return cb_setOffset_J;
		}

		static void n_SetOffset_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.IncaGetConversationsListRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IncaGetConversationsListRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		static IntPtr id_setOffset_J;
		public virtual unsafe long Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()J", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getOffset);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setOffset", "(J)V", "GetSetOffset_JHandler")]
			set {
				if (id_setOffset_J == IntPtr.Zero)
					id_setOffset_J = JNIEnv.GetMethodID (class_ref, "setOffset", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOffset_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffset", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static void n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Http.IncaGetConversationsListRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IncaGetConversationsListRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()V", "GetExecuteHandler")]
		public virtual unsafe void Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execute);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execute", "()V"));
			} finally {
			}
		}

		static Delegate cb_setOffset_I;
#pragma warning disable 0169
		static Delegate GetSetOffset_IHandler ()
		{
			if (cb_setOffset_I == null)
				cb_setOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOffset_I);
			return cb_setOffset_I;
		}

		static void n_SetOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Messaging.Network.Http.IncaGetConversationsListRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.IncaGetConversationsListRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOffset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOffset_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='IncaGetConversationsListRequest']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOffset", "(I)V", "GetSetOffset_IHandler")]
		public virtual unsafe void SetOffset (int p0)
		{
			if (id_setOffset_I == IntPtr.Zero)
				id_setOffset_I = JNIEnv.GetMethodID (class_ref, "setOffset", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOffset_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOffset", "(I)V"), __args);
			} finally {
			}
		}

	}
}
