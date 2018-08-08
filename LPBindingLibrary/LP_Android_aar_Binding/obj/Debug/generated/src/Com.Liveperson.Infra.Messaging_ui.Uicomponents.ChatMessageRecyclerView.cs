using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView", DoNotGenerateAcw=true)]
	public partial class ChatMessageRecyclerView : global::Android.Support.V7.Widget.RecyclerView, global::Com.Liveperson.Infra.UI.View.Uicomponents.IConnectionChangedCustomView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView.ListLoaderCallback']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView$ListLoaderCallback", DoNotGenerateAcw=true)]
		public partial class ListLoaderCallback : global::Java.Lang.Object, global::Android.Support.V4.App.LoaderManager.ILoaderCallbacks {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView$ListLoaderCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ListLoaderCallback); }
			}

			protected ListLoaderCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_ChatMessageRecyclerView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView.ListLoaderCallback']/constructor[@name='ChatMessageRecyclerView.ListLoaderCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.uicomponents.ChatMessageRecyclerView']]"
			[Register (".ctor", "(Lcom/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView;)V", "")]
			public unsafe ListLoaderCallback (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (ListLoaderCallback)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_ChatMessageRecyclerView_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_ChatMessageRecyclerView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_ChatMessageRecyclerView_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_messaging_ui_uicomponents_ChatMessageRecyclerView_, __args);
				} finally {
				}
			}

			static Delegate cb_onCreateLoader_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnCreateLoader_ILandroid_os_Bundle_Handler ()
			{
				if (cb_onCreateLoader_ILandroid_os_Bundle_ == null)
					cb_onCreateLoader_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnCreateLoader_ILandroid_os_Bundle_);
				return cb_onCreateLoader_ILandroid_os_Bundle_;
			}

			static IntPtr n_OnCreateLoader_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.ListLoaderCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.ListLoaderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateLoader (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onCreateLoader_ILandroid_os_Bundle_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView.ListLoaderCallback']/method[@name='onCreateLoader' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("onCreateLoader", "(ILandroid/os/Bundle;)Landroid/support/v4/content/CursorLoader;", "GetOnCreateLoader_ILandroid_os_Bundle_Handler")]
			public virtual unsafe global::Android.Support.V4.Content.Loader OnCreateLoader (int p0, global::Android.OS.Bundle p1)
			{
				if (id_onCreateLoader_ILandroid_os_Bundle_ == IntPtr.Zero)
					id_onCreateLoader_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreateLoader", "(ILandroid/os/Bundle;)Landroid/support/v4/content/CursorLoader;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Android.Support.V4.Content.Loader __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateLoader_ILandroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateLoader", "(ILandroid/os/Bundle;)Landroid/support/v4/content/CursorLoader;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_;
#pragma warning disable 0169
			static Delegate GetOnLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_Handler ()
			{
				if (cb_onLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_ == null)
					cb_onLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_);
				return cb_onLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_;
			}

			static void n_OnLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.ListLoaderCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.ListLoaderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V4.Content.Loader p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Database.ICursor p1 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnLoadFinished (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView.ListLoaderCallback']/method[@name='onLoadFinished' and count(parameter)=2 and parameter[1][@type='android.support.v4.content.Loader&lt;android.database.Cursor&gt;'] and parameter[2][@type='android.database.Cursor']]"
			[Register ("onLoadFinished", "(Landroid/support/v4/content/Loader;Landroid/database/Cursor;)V", "GetOnLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_Handler")]
			public virtual unsafe void OnLoadFinished (global::Android.Support.V4.Content.Loader p0, global::Android.Database.ICursor p1)
			{
				if (id_onLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_ == IntPtr.Zero)
					id_onLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "onLoadFinished", "(Landroid/support/v4/content/Loader;Landroid/database/Cursor;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadFinished_Landroid_support_v4_content_Loader_Landroid_database_Cursor_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoadFinished", "(Landroid/support/v4/content/Loader;Landroid/database/Cursor;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onLoaderReset_Landroid_support_v4_content_Loader_;
#pragma warning disable 0169
			static Delegate GetOnLoaderReset_Landroid_support_v4_content_Loader_Handler ()
			{
				if (cb_onLoaderReset_Landroid_support_v4_content_Loader_ == null)
					cb_onLoaderReset_Landroid_support_v4_content_Loader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoaderReset_Landroid_support_v4_content_Loader_);
				return cb_onLoaderReset_Landroid_support_v4_content_Loader_;
			}

			static void n_OnLoaderReset_Landroid_support_v4_content_Loader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.ListLoaderCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.ListLoaderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V4.Content.Loader p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLoaderReset (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onLoaderReset_Landroid_support_v4_content_Loader_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView.ListLoaderCallback']/method[@name='onLoaderReset' and count(parameter)=1 and parameter[1][@type='android.support.v4.content.Loader&lt;android.database.Cursor&gt;']]"
			[Register ("onLoaderReset", "(Landroid/support/v4/content/Loader;)V", "GetOnLoaderReset_Landroid_support_v4_content_Loader_Handler")]
			public virtual unsafe void OnLoaderReset (global::Android.Support.V4.Content.Loader p0)
			{
				if (id_onLoaderReset_Landroid_support_v4_content_Loader_ == IntPtr.Zero)
					id_onLoaderReset_Landroid_support_v4_content_Loader_ = JNIEnv.GetMethodID (class_ref, "onLoaderReset", "(Landroid/support/v4/content/Loader;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoaderReset_Landroid_support_v4_content_Loader_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoaderReset", "(Landroid/support/v4/content/Loader;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_;
#pragma warning disable 0169
			static Delegate GetSetCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_Handler ()
			{
				if (cb_setCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ == null)
					cb_setCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_);
				return cb_setCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_;
			}

			static void n_SetCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.ListLoaderCallback __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.ListLoaderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory p0 = (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetCursorLoaderFactory (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView.ListLoaderCallback']/method[@name='setCursorLoaderFactory' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.uicomponents.CursorLoaderFactory']]"
			[Register ("setCursorLoaderFactory", "(Lcom/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory;)V", "GetSetCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_Handler")]
			public virtual unsafe void SetCursorLoaderFactory (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory p0)
			{
				if (id_setCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ == IntPtr.Zero)
					id_setCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ = JNIEnv.GetMethodID (class_ref, "setCursorLoaderFactory", "(Lcom/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCursorLoaderFactory_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCursorLoaderFactory", "(Lcom/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='ChatMessageRecyclerView.OnLoadMoreListener']"
		[Register ("com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView$OnLoadMoreListener", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView/IOnLoadMoreListenerInvoker")]
		public partial interface IOnLoadMoreListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/interface[@name='ChatMessageRecyclerView.OnLoadMoreListener']/method[@name='onLoadMore' and count(parameter)=0]"
			[Register ("onLoadMore", "()V", "GetOnLoadMoreHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView/IOnLoadMoreListenerInvoker, LP_Android_aar_Binding")]
			void OnLoadMore ();

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView$OnLoadMoreListener", DoNotGenerateAcw=true)]
		internal class IOnLoadMoreListenerInvoker : global::Java.Lang.Object, IOnLoadMoreListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView$OnLoadMoreListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnLoadMoreListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnLoadMoreListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnLoadMoreListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.ChatMessageRecyclerView.OnLoadMoreListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnLoadMoreListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onLoadMore;
#pragma warning disable 0169
			static Delegate GetOnLoadMoreHandler ()
			{
				if (cb_onLoadMore == null)
					cb_onLoadMore = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLoadMore);
				return cb_onLoadMore;
			}

			static void n_OnLoadMore (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.IOnLoadMoreListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView.IOnLoadMoreListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnLoadMore ();
			}
#pragma warning restore 0169

			IntPtr id_onLoadMore;
			public unsafe void OnLoadMore ()
			{
				if (id_onLoadMore == IntPtr.Zero)
					id_onLoadMore = JNIEnv.GetMethodID (class_ref, "onLoadMore", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadMore);
			}

		}

		[global::Android.Runtime.Register ("mono/com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView_OnLoadMoreListenerImplementor")]
		internal sealed partial class IOnLoadMoreListenerImplementor : global::Java.Lang.Object, IOnLoadMoreListener {

			object sender;

			public IOnLoadMoreListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView_OnLoadMoreListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnLoadMore ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnLoadMoreListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/ChatMessageRecyclerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChatMessageRecyclerView); }
		}

		protected ChatMessageRecyclerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/constructor[@name='ChatMessageRecyclerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ChatMessageRecyclerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ChatMessageRecyclerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/constructor[@name='ChatMessageRecyclerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ChatMessageRecyclerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ChatMessageRecyclerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/constructor[@name='ChatMessageRecyclerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ChatMessageRecyclerView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ChatMessageRecyclerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getCopyBehavior;
#pragma warning disable 0169
		static Delegate GetGetCopyBehaviorHandler ()
		{
			if (cb_getCopyBehavior == null)
				cb_getCopyBehavior = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCopyBehavior);
			return cb_getCopyBehavior;
		}

		static IntPtr n_GetCopyBehavior (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CopyBehavior);
		}
#pragma warning restore 0169

		static Delegate cb_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
#pragma warning disable 0169
		static Delegate GetSetCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Handler ()
		{
			if (cb_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ == null)
				cb_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_);
			return cb_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
		}

		static void n_SetCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyBehavior = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCopyBehavior;
		static IntPtr id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_;
		public virtual unsafe global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior CopyBehavior {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='getCopyBehavior' and count(parameter)=0]"
			[Register ("getCopyBehavior", "()Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;", "GetGetCopyBehaviorHandler")]
			get {
				if (id_getCopyBehavior == IntPtr.Zero)
					id_getCopyBehavior = JNIEnv.GetMethodID (class_ref, "getCopyBehavior", "()Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCopyBehavior), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCopyBehavior", "()Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='setCopyBehavior' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.messaging_ui.view.adapter.copybehavior.CopyBehavior']]"
			[Register ("setCopyBehavior", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V", "GetSetCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_Handler")]
			set {
				if (id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ == IntPtr.Zero)
					id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_ = JNIEnv.GetMethodID (class_ref, "setCopyBehavior", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCopyBehavior_Lcom_liveperson_infra_messaging_ui_view_adapter_copybehavior_CopyBehavior_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCopyBehavior", "(Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public virtual unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_changeCursor_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetChangeCursor_Landroid_database_Cursor_Handler ()
		{
			if (cb_changeCursor_Landroid_database_Cursor_ == null)
				cb_changeCursor_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeCursor_Landroid_database_Cursor_);
			return cb_changeCursor_Landroid_database_Cursor_;
		}

		static void n_ChangeCursor_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeCursor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_changeCursor_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='changeCursor' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("changeCursor", "(Landroid/database/Cursor;)V", "GetChangeCursor_Landroid_database_Cursor_Handler")]
		public virtual unsafe void ChangeCursor (global::Android.Database.ICursor p0)
		{
			if (id_changeCursor_Landroid_database_Cursor_ == IntPtr.Zero)
				id_changeCursor_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "changeCursor", "(Landroid/database/Cursor;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeCursor_Landroid_database_Cursor_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeCursor", "(Landroid/database/Cursor;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_focusLastItem;
#pragma warning disable 0169
		static Delegate GetFocusLastItemHandler ()
		{
			if (cb_focusLastItem == null)
				cb_focusLastItem = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FocusLastItem);
			return cb_focusLastItem;
		}

		static void n_FocusLastItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FocusLastItem ();
		}
#pragma warning restore 0169

		static IntPtr id_focusLastItem;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='focusLastItem' and count(parameter)=0]"
		[Register ("focusLastItem", "()V", "GetFocusLastItemHandler")]
		public virtual unsafe void FocusLastItem ()
		{
			if (id_focusLastItem == IntPtr.Zero)
				id_focusLastItem = JNIEnv.GetMethodID (class_ref, "focusLastItem", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_focusLastItem);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "focusLastItem", "()V"));
			} finally {
			}
		}

		static Delegate cb_initListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_;
#pragma warning disable 0169
		static Delegate GetInitListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_Handler ()
		{
			if (cb_initListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ == null)
				cb_initListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InitListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_);
			return cb_initListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_;
		}

		static void n_InitListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.LoaderManager p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.LoaderManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Messaging p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Messaging> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory p2 = (global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InitListCursorLoader (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_initListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='initListCursorLoader' and count(parameter)=3 and parameter[1][@type='android.support.v4.app.LoaderManager'] and parameter[2][@type='com.liveperson.messaging.Messaging'] and parameter[3][@type='com.liveperson.infra.messaging_ui.uicomponents.CursorLoaderFactory']]"
		[Register ("initListCursorLoader", "(Landroid/support/v4/app/LoaderManager;Lcom/liveperson/messaging/Messaging;Lcom/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory;)V", "GetInitListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_Handler")]
		public virtual unsafe void InitListCursorLoader (global::Android.Support.V4.App.LoaderManager p0, global::Com.Liveperson.Messaging.Messaging p1, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ICursorLoaderFactory p2)
		{
			if (id_initListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ == IntPtr.Zero)
				id_initListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_ = JNIEnv.GetMethodID (class_ref, "initListCursorLoader", "(Landroid/support/v4/app/LoaderManager;Lcom/liveperson/messaging/Messaging;Lcom/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initListCursorLoader_Landroid_support_v4_app_LoaderManager_Lcom_liveperson_messaging_Messaging_Lcom_liveperson_infra_messaging_ui_uicomponents_CursorLoaderFactory_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initListCursorLoader", "(Landroid/support/v4/app/LoaderManager;Lcom/liveperson/messaging/Messaging;Lcom/liveperson/infra/messaging_ui/uicomponents/CursorLoaderFactory;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onConnectionChanged_Z;
#pragma warning disable 0169
		static Delegate GetOnConnectionChanged_ZHandler ()
		{
			if (cb_onConnectionChanged_Z == null)
				cb_onConnectionChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnConnectionChanged_Z);
			return cb_onConnectionChanged_Z;
		}

		static void n_OnConnectionChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionChanged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='onConnectionChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onConnectionChanged", "(Z)V", "GetOnConnectionChanged_ZHandler")]
		public virtual unsafe void OnConnectionChanged (bool p0)
		{
			if (id_onConnectionChanged_Z == IntPtr.Zero)
				id_onConnectionChanged_Z = JNIEnv.GetMethodID (class_ref, "onConnectionChanged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionChanged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionChanged", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLoaded;
#pragma warning disable 0169
		static Delegate GetSetLoadedHandler ()
		{
			if (cb_setLoaded == null)
				cb_setLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetLoaded);
			return cb_setLoaded;
		}

		static void n_SetLoaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLoaded ();
		}
#pragma warning restore 0169

		static IntPtr id_setLoaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='setLoaded' and count(parameter)=0]"
		[Register ("setLoaded", "()V", "GetSetLoadedHandler")]
		public virtual unsafe void SetLoaded ()
		{
			if (id_setLoaded == IntPtr.Zero)
				id_setLoaded = JNIEnv.GetMethodID (class_ref, "setLoaded", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLoaded);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoaded", "()V"));
			} finally {
			}
		}

		static Delegate cb_setMoveToBeginningOnNextUpdate;
#pragma warning disable 0169
		static Delegate GetSetMoveToBeginningOnNextUpdateHandler ()
		{
			if (cb_setMoveToBeginningOnNextUpdate == null)
				cb_setMoveToBeginningOnNextUpdate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetMoveToBeginningOnNextUpdate);
			return cb_setMoveToBeginningOnNextUpdate;
		}

		static void n_SetMoveToBeginningOnNextUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMoveToBeginningOnNextUpdate ();
		}
#pragma warning restore 0169

		static IntPtr id_setMoveToBeginningOnNextUpdate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents']/class[@name='ChatMessageRecyclerView']/method[@name='setMoveToBeginningOnNextUpdate' and count(parameter)=0]"
		[Register ("setMoveToBeginningOnNextUpdate", "()V", "GetSetMoveToBeginningOnNextUpdateHandler")]
		public virtual unsafe void SetMoveToBeginningOnNextUpdate ()
		{
			if (id_setMoveToBeginningOnNextUpdate == IntPtr.Zero)
				id_setMoveToBeginningOnNextUpdate = JNIEnv.GetMethodID (class_ref, "setMoveToBeginningOnNextUpdate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMoveToBeginningOnNextUpdate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMoveToBeginningOnNextUpdate", "()V"));
			} finally {
			}
		}

	}
}
