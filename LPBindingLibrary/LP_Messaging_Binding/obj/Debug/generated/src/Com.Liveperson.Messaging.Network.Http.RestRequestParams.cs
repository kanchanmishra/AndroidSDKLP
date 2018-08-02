using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Network.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='RestRequestParams']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/network/http/RestRequestParams", DoNotGenerateAcw=true)]
	public partial class RestRequestParams : global::Java.Lang.Object {


		static IntPtr mCertificates_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='RestRequestParams']/field[@name='mCertificates']"
		[Register ("mCertificates")]
		public global::System.Collections.IList MCertificates {
			get {
				if (mCertificates_jfieldId == IntPtr.Zero)
					mCertificates_jfieldId = JNIEnv.GetFieldID (class_ref, "mCertificates", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCertificates_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCertificates_jfieldId == IntPtr.Zero)
					mCertificates_jfieldId = JNIEnv.GetFieldID (class_ref, "mCertificates", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCertificates_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/network/http/RestRequestParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RestRequestParams); }
		}

		protected RestRequestParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='RestRequestParams']/constructor[@name='RestRequestParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RestRequestParams ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RestRequestParams)) {
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

		static Delegate cb_isNotValid;
#pragma warning disable 0169
		static Delegate GetIsNotValidHandler ()
		{
			if (cb_isNotValid == null)
				cb_isNotValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotValid);
			return cb_isNotValid;
		}

		static bool n_IsNotValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Network.Http.RestRequestParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotValid;
		}
#pragma warning restore 0169

		static IntPtr id_isNotValid;
		public virtual unsafe bool IsNotValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='RestRequestParams']/method[@name='isNotValid' and count(parameter)=0]"
			[Register ("isNotValid", "()Z", "GetIsNotValidHandler")]
			get {
				if (id_isNotValid == IntPtr.Zero)
					id_isNotValid = JNIEnv.GetMethodID (class_ref, "isNotValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_setParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_setParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == null)
				cb_setParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_);
			return cb_setParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_SetParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.Network.Http.RestRequestParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Network.Http.RestRequestParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetParams (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.network.http']/class[@name='RestRequestParams']/method[@name='setParams' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "GetSetParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe void SetParams (string p0, string p1, string p2, global::System.Collections.Generic.IList<string> p3)
		{
			if (id_setParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_setParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParams_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParams", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
