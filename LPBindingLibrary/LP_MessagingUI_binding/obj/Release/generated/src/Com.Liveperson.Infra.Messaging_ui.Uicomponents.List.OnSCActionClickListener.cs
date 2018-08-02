using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.List {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='OnSCActionClickListener']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener", DoNotGenerateAcw=true)]
	public abstract partial class OnSCActionClickListener : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OnSCActionClickListener); }
		}

		protected OnSCActionClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='OnSCActionClickListener']/constructor[@name='OnSCActionClickListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OnSCActionClickListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OnSCActionClickListener)) {
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

		static Delegate cb_onClick_Lorg_json_JSONArray_;
#pragma warning disable 0169
		static Delegate GetOnClick_Lorg_json_JSONArray_Handler ()
		{
			if (cb_onClick_Lorg_json_JSONArray_ == null)
				cb_onClick_Lorg_json_JSONArray_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClick_Lorg_json_JSONArray_);
			return cb_onClick_Lorg_json_JSONArray_;
		}

		static void n_OnClick_Lorg_json_JSONArray_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.OnSCActionClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONArray p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='OnSCActionClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("onClick", "(Lorg/json/JSONArray;)V", "GetOnClick_Lorg_json_JSONArray_Handler")]
		public abstract void OnClick (global::Org.Json.JSONArray p0);

	}

	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/OnSCActionClickListener", DoNotGenerateAcw=true)]
	internal partial class OnSCActionClickListenerInvoker : OnSCActionClickListener {

		public OnSCActionClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OnSCActionClickListenerInvoker); }
		}

		static IntPtr id_onClick_Lorg_json_JSONArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='OnSCActionClickListener']/method[@name='onClick' and count(parameter)=1 and parameter[1][@type='org.json.JSONArray']]"
		[Register ("onClick", "(Lorg/json/JSONArray;)V", "GetOnClick_Lorg_json_JSONArray_Handler")]
		public override unsafe void OnClick (global::Org.Json.JSONArray p0)
		{
			if (id_onClick_Lorg_json_JSONArray_ == IntPtr.Zero)
				id_onClick_Lorg_json_JSONArray_ = JNIEnv.GetMethodID (class_ref, "onClick", "(Lorg/json/JSONArray;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Lorg_json_JSONArray_, __args);
			} finally {
			}
		}

	}

}
