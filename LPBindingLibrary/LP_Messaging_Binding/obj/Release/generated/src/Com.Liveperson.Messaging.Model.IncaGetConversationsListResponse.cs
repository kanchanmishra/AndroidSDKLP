using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='IncaGetConversationsListResponse']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/model/IncaGetConversationsListResponse", DoNotGenerateAcw=true)]
	public partial class IncaGetConversationsListResponse : global::Java.Lang.Object {


		static IntPtr mNextUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='IncaGetConversationsListResponse']/field[@name='mNextUrl']"
		[Register ("mNextUrl")]
		public string MNextUrl {
			get {
				if (mNextUrl_jfieldId == IntPtr.Zero)
					mNextUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mNextUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mNextUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mNextUrl_jfieldId == IntPtr.Zero)
					mNextUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mNextUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mNextUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/model/IncaGetConversationsListResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IncaGetConversationsListResponse); }
		}

		protected IncaGetConversationsListResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='IncaGetConversationsListResponse']/constructor[@name='IncaGetConversationsListResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe IncaGetConversationsListResponse (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (IncaGetConversationsListResponse)) {
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

		static Delegate cb_getListOfConversations;
#pragma warning disable 0169
		static Delegate GetGetListOfConversationsHandler ()
		{
			if (cb_getListOfConversations == null)
				cb_getListOfConversations = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListOfConversations);
			return cb_getListOfConversations;
		}

		static IntPtr n_GetListOfConversations (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.IncaGetConversationsListResponse __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IncaGetConversationsListResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Model.ConversationINCADetails>.ToLocalJniHandle (__this.ListOfConversations);
		}
#pragma warning restore 0169

		static IntPtr id_getListOfConversations;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Liveperson.Api.Response.Model.ConversationINCADetails> ListOfConversations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='IncaGetConversationsListResponse']/method[@name='getListOfConversations' and count(parameter)=0]"
			[Register ("getListOfConversations", "()Ljava/util/ArrayList;", "GetGetListOfConversationsHandler")]
			get {
				if (id_getListOfConversations == IntPtr.Zero)
					id_getListOfConversations = JNIEnv.GetMethodID (class_ref, "getListOfConversations", "()Ljava/util/ArrayList;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Model.ConversationINCADetails>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getListOfConversations), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Liveperson.Api.Response.Model.ConversationINCADetails>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListOfConversations", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumOfResults;
#pragma warning disable 0169
		static Delegate GetGetNumOfResultsHandler ()
		{
			if (cb_getNumOfResults == null)
				cb_getNumOfResults = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumOfResults);
			return cb_getNumOfResults;
		}

		static int n_GetNumOfResults (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.IncaGetConversationsListResponse __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IncaGetConversationsListResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumOfResults;
		}
#pragma warning restore 0169

		static IntPtr id_getNumOfResults;
		public virtual unsafe int NumOfResults {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='IncaGetConversationsListResponse']/method[@name='getNumOfResults' and count(parameter)=0]"
			[Register ("getNumOfResults", "()I", "GetGetNumOfResultsHandler")]
			get {
				if (id_getNumOfResults == IntPtr.Zero)
					id_getNumOfResults = JNIEnv.GetMethodID (class_ref, "getNumOfResults", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumOfResults);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumOfResults", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUrlRef;
#pragma warning disable 0169
		static Delegate GetGetUrlRefHandler ()
		{
			if (cb_getUrlRef == null)
				cb_getUrlRef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrlRef);
			return cb_getUrlRef;
		}

		static IntPtr n_GetUrlRef (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Model.IncaGetConversationsListResponse __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.IncaGetConversationsListResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UrlRef);
		}
#pragma warning restore 0169

		static IntPtr id_getUrlRef;
		public virtual unsafe string UrlRef {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.model']/class[@name='IncaGetConversationsListResponse']/method[@name='getUrlRef' and count(parameter)=0]"
			[Register ("getUrlRef", "()Ljava/lang/String;", "GetGetUrlRefHandler")]
			get {
				if (id_getUrlRef == IntPtr.Zero)
					id_getUrlRef = JNIEnv.GetMethodID (class_ref, "getUrlRef", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrlRef), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrlRef", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
