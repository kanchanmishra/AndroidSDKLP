using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Network.Http.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='CSDSRequest']"
	[global::Android.Runtime.Register ("com/liveperson/infra/network/http/requests/CSDSRequest", DoNotGenerateAcw=true)]
	public partial class CSDSRequest : global::Java.Lang.Object, global::Com.Liveperson.Infra.ICommand {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/network/http/requests/CSDSRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CSDSRequest); }
		}

		protected CSDSRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_ICallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='CSDSRequest']/constructor[@name='CSDSRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='com.liveperson.infra.ICallback']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Lcom/liveperson/infra/ICallback;)V", "")]
		public unsafe CSDSRequest (string p0, string p1, global::System.Collections.Generic.IList<string> p2, global::Com.Liveperson.Infra.ICallback p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (CSDSRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Lcom/liveperson/infra/ICallback;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Lcom/liveperson/infra/ICallback;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Lcom/liveperson/infra/ICallback;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_ICallback_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Lcom_liveperson_infra_ICallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Liveperson.Infra.Network.Http.Requests.CSDSRequest __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Network.Http.Requests.CSDSRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Execute ();
		}
#pragma warning restore 0169

		static IntPtr id_execute;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.network.http.requests']/class[@name='CSDSRequest']/method[@name='execute' and count(parameter)=0]"
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

	}
}
