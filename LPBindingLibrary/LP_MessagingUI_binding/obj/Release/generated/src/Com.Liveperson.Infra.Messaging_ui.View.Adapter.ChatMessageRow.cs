using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.View.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.view.adapter']/class[@name='ChatMessageRow']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow", DoNotGenerateAcw=true)]
	public partial class ChatMessageRow : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/view/adapter/ChatMessageRow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChatMessageRow); }
		}

		protected ChatMessageRow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
