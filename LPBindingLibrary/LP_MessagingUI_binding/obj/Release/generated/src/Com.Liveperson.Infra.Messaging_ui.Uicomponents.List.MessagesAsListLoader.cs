using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Uicomponents.List {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader", DoNotGenerateAcw=true)]
	public partial class MessagesAsListLoader : global::Java.Lang.Object, global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListener {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.IHandlerProvider']"
		[Register ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader$IHandlerProvider", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IHandlerProviderInvoker")]
		public partial interface IHandlerProvider : IJavaObject {

			global::Android.Content.Context Context {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.IHandlerProvider']/method[@name='getContext' and count(parameter)=0]"
				[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IHandlerProviderInvoker, LP_MessagingUI_binding")] get;
			}

			global::Android.Views.View View {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.IHandlerProvider']/method[@name='getView' and count(parameter)=0]"
				[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IHandlerProviderInvoker, LP_MessagingUI_binding")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.IHandlerProvider']/method[@name='post' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("post", "(Ljava/lang/Runnable;)Z", "GetPost_Ljava_lang_Runnable_Handler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IHandlerProviderInvoker, LP_MessagingUI_binding")]
			bool Post (global::Java.Lang.IRunnable p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.IHandlerProvider']/method[@name='postDelayed' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='long']]"
			[Register ("postDelayed", "(Ljava/lang/Runnable;J)Z", "GetPostDelayed_Ljava_lang_Runnable_JHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IHandlerProviderInvoker, LP_MessagingUI_binding")]
			bool PostDelayed (global::Java.Lang.IRunnable p0, long p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.IHandlerProvider']/method[@name='removeCallbacks' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
			[Register ("removeCallbacks", "(Ljava/lang/Runnable;)Z", "GetRemoveCallbacks_Ljava_lang_Runnable_Handler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IHandlerProviderInvoker, LP_MessagingUI_binding")]
			bool RemoveCallbacks (global::Java.Lang.IRunnable p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader$IHandlerProvider", DoNotGenerateAcw=true)]
		internal class IHandlerProviderInvoker : global::Java.Lang.Object, IHandlerProvider {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader$IHandlerProvider");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IHandlerProviderInvoker); }
			}

			IntPtr class_ref;

			public static IHandlerProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IHandlerProvider> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.list.MessagesAsListLoader.IHandlerProvider"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IHandlerProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getContext;
#pragma warning disable 0169
			static Delegate GetGetContextHandler ()
			{
				if (cb_getContext == null)
					cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
				return cb_getContext;
			}

			static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Context);
			}
#pragma warning restore 0169

			IntPtr id_getContext;
			public unsafe global::Android.Content.Context Context {
				get {
					if (id_getContext == IntPtr.Zero)
						id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_getView;
#pragma warning disable 0169
			static Delegate GetGetViewHandler ()
			{
				if (cb_getView == null)
					cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
				return cb_getView;
			}

			static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.View);
			}
#pragma warning restore 0169

			IntPtr id_getView;
			public unsafe global::Android.Views.View View {
				get {
					if (id_getView == IntPtr.Zero)
						id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_post_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetPost_Ljava_lang_Runnable_Handler ()
			{
				if (cb_post_Ljava_lang_Runnable_ == null)
					cb_post_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Post_Ljava_lang_Runnable_);
				return cb_post_Ljava_lang_Runnable_;
			}

			static bool n_Post_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Post (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_post_Ljava_lang_Runnable_;
			public unsafe bool Post (global::Java.Lang.IRunnable p0)
			{
				if (id_post_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_post_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/Runnable;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_Runnable_, __args);
				return __ret;
			}

			static Delegate cb_postDelayed_Ljava_lang_Runnable_J;
#pragma warning disable 0169
			static Delegate GetPostDelayed_Ljava_lang_Runnable_JHandler ()
			{
				if (cb_postDelayed_Ljava_lang_Runnable_J == null)
					cb_postDelayed_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool>) n_PostDelayed_Ljava_lang_Runnable_J);
				return cb_postDelayed_Ljava_lang_Runnable_J;
			}

			static bool n_PostDelayed_Ljava_lang_Runnable_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.PostDelayed (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_postDelayed_Ljava_lang_Runnable_J;
			public unsafe bool PostDelayed (global::Java.Lang.IRunnable p0, long p1)
			{
				if (id_postDelayed_Ljava_lang_Runnable_J == IntPtr.Zero)
					id_postDelayed_Ljava_lang_Runnable_J = JNIEnv.GetMethodID (class_ref, "postDelayed", "(Ljava/lang/Runnable;J)Z");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_postDelayed_Ljava_lang_Runnable_J, __args);
				return __ret;
			}

			static Delegate cb_removeCallbacks_Ljava_lang_Runnable_;
#pragma warning disable 0169
			static Delegate GetRemoveCallbacks_Ljava_lang_Runnable_Handler ()
			{
				if (cb_removeCallbacks_Ljava_lang_Runnable_ == null)
					cb_removeCallbacks_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveCallbacks_Ljava_lang_Runnable_);
				return cb_removeCallbacks_Ljava_lang_Runnable_;
			}

			static bool n_RemoveCallbacks_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IHandlerProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RemoveCallbacks (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_removeCallbacks_Ljava_lang_Runnable_;
			public unsafe bool RemoveCallbacks (global::Java.Lang.IRunnable p0)
			{
				if (id_removeCallbacks_Ljava_lang_Runnable_ == IntPtr.Zero)
					id_removeCallbacks_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "removeCallbacks", "(Ljava/lang/Runnable;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeCallbacks_Ljava_lang_Runnable_, __args);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader.LoadingMessagesHandler']"
		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader$LoadingMessagesHandler", DoNotGenerateAcw=true)]
		public partial class LoadingMessagesHandler : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader.LoadingMessagesHandler']/field[@name='FIRST_PHASE_DELAY_MILLIS']"
			[Register ("FIRST_PHASE_DELAY_MILLIS")]
			public const int FirstPhaseDelayMillis = (int) 1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader.LoadingMessagesHandler']/field[@name='SECOND_PHASE_DELAY_MILLIS']"
			[Register ("SECOND_PHASE_DELAY_MILLIS")]
			public const int SecondPhaseDelayMillis = (int) 10000;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader$LoadingMessagesHandler", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LoadingMessagesHandler); }
			}

			protected LoadingMessagesHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_removeAgentIsTyping;
#pragma warning disable 0169
			static Delegate GetRemoveAgentIsTypingHandler ()
			{
				if (cb_removeAgentIsTyping == null)
					cb_removeAgentIsTyping = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAgentIsTyping);
				return cb_removeAgentIsTyping;
			}

			static void n_RemoveAgentIsTyping (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.LoadingMessagesHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.LoadingMessagesHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.RemoveAgentIsTyping ();
			}
#pragma warning restore 0169

			static IntPtr id_removeAgentIsTyping;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader.LoadingMessagesHandler']/method[@name='removeAgentIsTyping' and count(parameter)=0]"
			[Register ("removeAgentIsTyping", "()V", "GetRemoveAgentIsTypingHandler")]
			public virtual unsafe void RemoveAgentIsTyping ()
			{
				if (id_removeAgentIsTyping == IntPtr.Zero)
					id_removeAgentIsTyping = JNIEnv.GetMethodID (class_ref, "removeAgentIsTyping", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAgentIsTyping);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAgentIsTyping", "()V"));
				} finally {
				}
			}

			static Delegate cb_showAgentIsTyping_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetShowAgentIsTyping_Ljava_lang_String_Handler ()
			{
				if (cb_showAgentIsTyping_Ljava_lang_String_ == null)
					cb_showAgentIsTyping_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowAgentIsTyping_Ljava_lang_String_);
				return cb_showAgentIsTyping_Ljava_lang_String_;
			}

			static void n_ShowAgentIsTyping_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_originatorId)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.LoadingMessagesHandler __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.LoadingMessagesHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string originatorId = JNIEnv.GetString (native_originatorId, JniHandleOwnership.DoNotTransfer);
				__this.ShowAgentIsTyping (originatorId);
			}
#pragma warning restore 0169

			static IntPtr id_showAgentIsTyping_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader.LoadingMessagesHandler']/method[@name='showAgentIsTyping' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("showAgentIsTyping", "(Ljava/lang/String;)V", "GetShowAgentIsTyping_Ljava_lang_String_Handler")]
			public virtual unsafe void ShowAgentIsTyping (string originatorId)
			{
				if (id_showAgentIsTyping_Ljava_lang_String_ == IntPtr.Zero)
					id_showAgentIsTyping_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "showAgentIsTyping", "(Ljava/lang/String;)V");
				IntPtr native_originatorId = JNIEnv.NewString (originatorId);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_originatorId);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showAgentIsTyping_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showAgentIsTyping", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_originatorId);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']"
		[Register ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader$OnListUpdated", "", "Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker")]
		public partial interface IOnListUpdated : IJavaObject {

			int FirstVisibleItemPosition {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='getFirstVisibleItemPosition' and count(parameter)=0]"
				[Register ("getFirstVisibleItemPosition", "()I", "GetGetFirstVisibleItemPositionHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")] get;
			}

			int LastVisibleItemPosition {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='getLastVisibleItemPosition' and count(parameter)=0]"
				[Register ("getLastVisibleItemPosition", "()I", "GetGetLastVisibleItemPositionHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='notifyUnreadMessagesChanged' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("notifyUnreadMessagesChanged", "(ILjava/lang/String;I)V", "GetNotifyUnreadMessagesChanged_ILjava_lang_String_IHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void NotifyUnreadMessagesChanged (int p0, string p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onClearAllMessages' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onClearAllMessages", "(II)V", "GetOnClearAllMessages_IIHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnClearAllMessages (int p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onHistoryLoaded' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("onHistoryLoaded", "(IIZ)V", "GetOnHistoryLoaded_IIZHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnHistoryLoaded (int p0, int p1, bool p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onItemMoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onItemMoved", "(II)V", "GetOnItemMoved_IIHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnItemMoved (int p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onItemRemoved' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onItemRemoved", "(I)V", "GetOnItemRemoved_IHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnItemRemoved (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onMessageUpdated' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("onMessageUpdated", "(ILandroid/os/Bundle;)V", "GetOnMessageUpdated_ILandroid_os_Bundle_Handler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnMessageUpdated (int p0, global::Android.OS.Bundle p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onNewAgentMessagesLoaded' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("onNewAgentMessagesLoaded", "(II)V", "GetOnNewAgentMessagesLoaded_IIHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnNewAgentMessagesLoaded (int p0, int p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onNewMessagesLoaded' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onNewMessagesLoaded", "(III)V", "GetOnNewMessagesLoaded_IIIHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnNewMessagesLoaded (int p0, int p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onNewUnreadMessages' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onNewUnreadMessages", "(I)V", "GetOnNewUnreadMessages_IHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnNewUnreadMessages (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/interface[@name='MessagesAsListLoader.OnListUpdated']/method[@name='onNewUserMessageAdded' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onNewUserMessageAdded", "(I)V", "GetOnNewUserMessageAdded_IHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader/IOnListUpdatedInvoker, LP_MessagingUI_binding")]
			void OnNewUserMessageAdded (int p0);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader$OnListUpdated", DoNotGenerateAcw=true)]
		internal class IOnListUpdatedInvoker : global::Java.Lang.Object, IOnListUpdated {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader$OnListUpdated");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnListUpdatedInvoker); }
			}

			IntPtr class_ref;

			public static IOnListUpdated GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnListUpdated> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.messaging_ui.uicomponents.list.MessagesAsListLoader.OnListUpdated"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnListUpdatedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getFirstVisibleItemPosition;
#pragma warning disable 0169
			static Delegate GetGetFirstVisibleItemPositionHandler ()
			{
				if (cb_getFirstVisibleItemPosition == null)
					cb_getFirstVisibleItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirstVisibleItemPosition);
				return cb_getFirstVisibleItemPosition;
			}

			static int n_GetFirstVisibleItemPosition (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FirstVisibleItemPosition;
			}
#pragma warning restore 0169

			IntPtr id_getFirstVisibleItemPosition;
			public unsafe int FirstVisibleItemPosition {
				get {
					if (id_getFirstVisibleItemPosition == IntPtr.Zero)
						id_getFirstVisibleItemPosition = JNIEnv.GetMethodID (class_ref, "getFirstVisibleItemPosition", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFirstVisibleItemPosition);
				}
			}

			static Delegate cb_getLastVisibleItemPosition;
#pragma warning disable 0169
			static Delegate GetGetLastVisibleItemPositionHandler ()
			{
				if (cb_getLastVisibleItemPosition == null)
					cb_getLastVisibleItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastVisibleItemPosition);
				return cb_getLastVisibleItemPosition;
			}

			static int n_GetLastVisibleItemPosition (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LastVisibleItemPosition;
			}
#pragma warning restore 0169

			IntPtr id_getLastVisibleItemPosition;
			public unsafe int LastVisibleItemPosition {
				get {
					if (id_getLastVisibleItemPosition == IntPtr.Zero)
						id_getLastVisibleItemPosition = JNIEnv.GetMethodID (class_ref, "getLastVisibleItemPosition", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastVisibleItemPosition);
				}
			}

			static Delegate cb_notifyUnreadMessagesChanged_ILjava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetNotifyUnreadMessagesChanged_ILjava_lang_String_IHandler ()
			{
				if (cb_notifyUnreadMessagesChanged_ILjava_lang_String_I == null)
					cb_notifyUnreadMessagesChanged_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int>) n_NotifyUnreadMessagesChanged_ILjava_lang_String_I);
				return cb_notifyUnreadMessagesChanged_ILjava_lang_String_I;
			}

			static void n_NotifyUnreadMessagesChanged_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.NotifyUnreadMessagesChanged (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_notifyUnreadMessagesChanged_ILjava_lang_String_I;
			public unsafe void NotifyUnreadMessagesChanged (int p0, string p1, int p2)
			{
				if (id_notifyUnreadMessagesChanged_ILjava_lang_String_I == IntPtr.Zero)
					id_notifyUnreadMessagesChanged_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "notifyUnreadMessagesChanged", "(ILjava/lang/String;I)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyUnreadMessagesChanged_ILjava_lang_String_I, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_onClearAllMessages_II;
#pragma warning disable 0169
			static Delegate GetOnClearAllMessages_IIHandler ()
			{
				if (cb_onClearAllMessages_II == null)
					cb_onClearAllMessages_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnClearAllMessages_II);
				return cb_onClearAllMessages_II;
			}

			static void n_OnClearAllMessages_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnClearAllMessages (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onClearAllMessages_II;
			public unsafe void OnClearAllMessages (int p0, int p1)
			{
				if (id_onClearAllMessages_II == IntPtr.Zero)
					id_onClearAllMessages_II = JNIEnv.GetMethodID (class_ref, "onClearAllMessages", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClearAllMessages_II, __args);
			}

			static Delegate cb_onHistoryLoaded_IIZ;
#pragma warning disable 0169
			static Delegate GetOnHistoryLoaded_IIZHandler ()
			{
				if (cb_onHistoryLoaded_IIZ == null)
					cb_onHistoryLoaded_IIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, bool>) n_OnHistoryLoaded_IIZ);
				return cb_onHistoryLoaded_IIZ;
			}

			static void n_OnHistoryLoaded_IIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, bool p2)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnHistoryLoaded (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onHistoryLoaded_IIZ;
			public unsafe void OnHistoryLoaded (int p0, int p1, bool p2)
			{
				if (id_onHistoryLoaded_IIZ == IntPtr.Zero)
					id_onHistoryLoaded_IIZ = JNIEnv.GetMethodID (class_ref, "onHistoryLoaded", "(IIZ)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHistoryLoaded_IIZ, __args);
			}

			static Delegate cb_onItemMoved_II;
#pragma warning disable 0169
			static Delegate GetOnItemMoved_IIHandler ()
			{
				if (cb_onItemMoved_II == null)
					cb_onItemMoved_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnItemMoved_II);
				return cb_onItemMoved_II;
			}

			static void n_OnItemMoved_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnItemMoved (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onItemMoved_II;
			public unsafe void OnItemMoved (int p0, int p1)
			{
				if (id_onItemMoved_II == IntPtr.Zero)
					id_onItemMoved_II = JNIEnv.GetMethodID (class_ref, "onItemMoved", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemMoved_II, __args);
			}

			static Delegate cb_onItemRemoved_I;
#pragma warning disable 0169
			static Delegate GetOnItemRemoved_IHandler ()
			{
				if (cb_onItemRemoved_I == null)
					cb_onItemRemoved_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnItemRemoved_I);
				return cb_onItemRemoved_I;
			}

			static void n_OnItemRemoved_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnItemRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_onItemRemoved_I;
			public unsafe void OnItemRemoved (int p0)
			{
				if (id_onItemRemoved_I == IntPtr.Zero)
					id_onItemRemoved_I = JNIEnv.GetMethodID (class_ref, "onItemRemoved", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemRemoved_I, __args);
			}

			static Delegate cb_onMessageUpdated_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetOnMessageUpdated_ILandroid_os_Bundle_Handler ()
			{
				if (cb_onMessageUpdated_ILandroid_os_Bundle_ == null)
					cb_onMessageUpdated_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnMessageUpdated_ILandroid_os_Bundle_);
				return cb_onMessageUpdated_ILandroid_os_Bundle_;
			}

			static void n_OnMessageUpdated_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnMessageUpdated (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onMessageUpdated_ILandroid_os_Bundle_;
			public unsafe void OnMessageUpdated (int p0, global::Android.OS.Bundle p1)
			{
				if (id_onMessageUpdated_ILandroid_os_Bundle_ == IntPtr.Zero)
					id_onMessageUpdated_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onMessageUpdated", "(ILandroid/os/Bundle;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMessageUpdated_ILandroid_os_Bundle_, __args);
			}

			static Delegate cb_onNewAgentMessagesLoaded_II;
#pragma warning disable 0169
			static Delegate GetOnNewAgentMessagesLoaded_IIHandler ()
			{
				if (cb_onNewAgentMessagesLoaded_II == null)
					cb_onNewAgentMessagesLoaded_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnNewAgentMessagesLoaded_II);
				return cb_onNewAgentMessagesLoaded_II;
			}

			static void n_OnNewAgentMessagesLoaded_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNewAgentMessagesLoaded (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onNewAgentMessagesLoaded_II;
			public unsafe void OnNewAgentMessagesLoaded (int p0, int p1)
			{
				if (id_onNewAgentMessagesLoaded_II == IntPtr.Zero)
					id_onNewAgentMessagesLoaded_II = JNIEnv.GetMethodID (class_ref, "onNewAgentMessagesLoaded", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewAgentMessagesLoaded_II, __args);
			}

			static Delegate cb_onNewMessagesLoaded_III;
#pragma warning disable 0169
			static Delegate GetOnNewMessagesLoaded_IIIHandler ()
			{
				if (cb_onNewMessagesLoaded_III == null)
					cb_onNewMessagesLoaded_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_OnNewMessagesLoaded_III);
				return cb_onNewMessagesLoaded_III;
			}

			static void n_OnNewMessagesLoaded_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNewMessagesLoaded (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onNewMessagesLoaded_III;
			public unsafe void OnNewMessagesLoaded (int p0, int p1, int p2)
			{
				if (id_onNewMessagesLoaded_III == IntPtr.Zero)
					id_onNewMessagesLoaded_III = JNIEnv.GetMethodID (class_ref, "onNewMessagesLoaded", "(III)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewMessagesLoaded_III, __args);
			}

			static Delegate cb_onNewUnreadMessages_I;
#pragma warning disable 0169
			static Delegate GetOnNewUnreadMessages_IHandler ()
			{
				if (cb_onNewUnreadMessages_I == null)
					cb_onNewUnreadMessages_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnNewUnreadMessages_I);
				return cb_onNewUnreadMessages_I;
			}

			static void n_OnNewUnreadMessages_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNewUnreadMessages (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNewUnreadMessages_I;
			public unsafe void OnNewUnreadMessages (int p0)
			{
				if (id_onNewUnreadMessages_I == IntPtr.Zero)
					id_onNewUnreadMessages_I = JNIEnv.GetMethodID (class_ref, "onNewUnreadMessages", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewUnreadMessages_I, __args);
			}

			static Delegate cb_onNewUserMessageAdded_I;
#pragma warning disable 0169
			static Delegate GetOnNewUserMessageAdded_IHandler ()
			{
				if (cb_onNewUserMessageAdded_I == null)
					cb_onNewUserMessageAdded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnNewUserMessageAdded_I);
				return cb_onNewUserMessageAdded_I;
			}

			static void n_OnNewUserMessageAdded_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader.IOnListUpdated> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNewUserMessageAdded (p0);
			}
#pragma warning restore 0169

			IntPtr id_onNewUserMessageAdded_I;
			public unsafe void OnNewUserMessageAdded (int p0)
			{
				if (id_onNewUserMessageAdded_I == IntPtr.Zero)
					id_onNewUserMessageAdded_I = JNIEnv.GetMethodID (class_ref, "onNewUserMessageAdded", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNewUserMessageAdded_I, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/uicomponents/list/MessagesAsListLoader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessagesAsListLoader); }
		}

		protected MessagesAsListLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getUnreadPosition;
#pragma warning disable 0169
		static Delegate GetGetUnreadPositionHandler ()
		{
			if (cb_getUnreadPosition == null)
				cb_getUnreadPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnreadPosition);
			return cb_getUnreadPosition;
		}

		static int n_GetUnreadPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnreadPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadPosition;
		public virtual unsafe int UnreadPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='getUnreadPosition' and count(parameter)=0]"
			[Register ("getUnreadPosition", "()I", "GetGetUnreadPositionHandler")]
			get {
				if (id_getUnreadPosition == IntPtr.Zero)
					id_getUnreadPosition = JNIEnv.GetMethodID (class_ref, "getUnreadPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTimeAtPosition_I;
#pragma warning disable 0169
		static Delegate GetGetTimeAtPosition_IHandler ()
		{
			if (cb_getTimeAtPosition_I == null)
				cb_getTimeAtPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetTimeAtPosition_I);
			return cb_getTimeAtPosition_I;
		}

		static long n_GetTimeAtPosition_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetTimeAtPosition (position);
		}
#pragma warning restore 0169

		static IntPtr id_getTimeAtPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='getTimeAtPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTimeAtPosition", "(I)J", "GetGetTimeAtPosition_IHandler")]
		public virtual unsafe long GetTimeAtPosition (int position)
		{
			if (id_getTimeAtPosition_I == IntPtr.Zero)
				id_getTimeAtPosition_I = JNIEnv.GetMethodID (class_ref, "getTimeAtPosition", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (position);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeAtPosition_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeAtPosition", "(I)J"), __args);
			} finally {
			}
		}

		static Delegate cb_onAgentIsTyping_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAgentIsTyping_ZLjava_lang_String_Handler ()
		{
			if (cb_onAgentIsTyping_ZLjava_lang_String_ == null)
				cb_onAgentIsTyping_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnAgentIsTyping_ZLjava_lang_String_);
			return cb_onAgentIsTyping_ZLjava_lang_String_;
		}

		static void n_OnAgentIsTyping_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool isAgentTyping, IntPtr native_originatorId)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string originatorId = JNIEnv.GetString (native_originatorId, JniHandleOwnership.DoNotTransfer);
			__this.OnAgentIsTyping (isAgentTyping, originatorId);
		}
#pragma warning restore 0169

		static IntPtr id_onAgentIsTyping_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='onAgentIsTyping' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAgentIsTyping", "(ZLjava/lang/String;)V", "GetOnAgentIsTyping_ZLjava_lang_String_Handler")]
		public virtual unsafe void OnAgentIsTyping (bool isAgentTyping, string originatorId)
		{
			if (id_onAgentIsTyping_ZLjava_lang_String_ == IntPtr.Zero)
				id_onAgentIsTyping_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAgentIsTyping", "(ZLjava/lang/String;)V");
			IntPtr native_originatorId = JNIEnv.NewString (originatorId);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (isAgentTyping);
				__args [1] = new JValue (native_originatorId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAgentIsTyping_ZLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAgentIsTyping", "(ZLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_originatorId);
			}
		}

		static Delegate cb_onBackground;
#pragma warning disable 0169
		static Delegate GetOnBackgroundHandler ()
		{
			if (cb_onBackground == null)
				cb_onBackground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBackground);
			return cb_onBackground;
		}

		static void n_OnBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBackground ();
		}
#pragma warning restore 0169

		static IntPtr id_onBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='onBackground' and count(parameter)=0]"
		[Register ("onBackground", "()V", "GetOnBackgroundHandler")]
		public virtual unsafe void OnBackground ()
		{
			if (id_onBackground == IntPtr.Zero)
				id_onBackground = JNIEnv.GetMethodID (class_ref, "onBackground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBackground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBackground", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConnectionAvailable;
#pragma warning disable 0169
		static Delegate GetOnConnectionAvailableHandler ()
		{
			if (cb_onConnectionAvailable == null)
				cb_onConnectionAvailable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionAvailable);
			return cb_onConnectionAvailable;
		}

		static void n_OnConnectionAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionAvailable ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionAvailable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='onConnectionAvailable' and count(parameter)=0]"
		[Register ("onConnectionAvailable", "()V", "GetOnConnectionAvailableHandler")]
		public virtual unsafe void OnConnectionAvailable ()
		{
			if (id_onConnectionAvailable == IntPtr.Zero)
				id_onConnectionAvailable = JNIEnv.GetMethodID (class_ref, "onConnectionAvailable", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionAvailable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionAvailable", "()V"));
			} finally {
			}
		}

		static Delegate cb_onConnectionLost;
#pragma warning disable 0169
		static Delegate GetOnConnectionLostHandler ()
		{
			if (cb_onConnectionLost == null)
				cb_onConnectionLost = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionLost);
			return cb_onConnectionLost;
		}

		static void n_OnConnectionLost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionLost ();
		}
#pragma warning restore 0169

		static IntPtr id_onConnectionLost;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='onConnectionLost' and count(parameter)=0]"
		[Register ("onConnectionLost", "()V", "GetOnConnectionLostHandler")]
		public virtual unsafe void OnConnectionLost ()
		{
			if (id_onConnectionLost == IntPtr.Zero)
				id_onConnectionLost = JNIEnv.GetMethodID (class_ref, "onConnectionLost", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionLost);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnectionLost", "()V"));
			} finally {
			}
		}

		static Delegate cb_onForeground;
#pragma warning disable 0169
		static Delegate GetOnForegroundHandler ()
		{
			if (cb_onForeground == null)
				cb_onForeground = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnForeground);
			return cb_onForeground;
		}

		static void n_OnForeground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnForeground ();
		}
#pragma warning restore 0169

		static IntPtr id_onForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='onForeground' and count(parameter)=0]"
		[Register ("onForeground", "()V", "GetOnForegroundHandler")]
		public virtual unsafe void OnForeground ()
		{
			if (id_onForeground == IntPtr.Zero)
				id_onForeground = JNIEnv.GetMethodID (class_ref, "onForeground", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onForeground);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onForeground", "()V"));
			} finally {
			}
		}

		static Delegate cb_onScroll_I;
#pragma warning disable 0169
		static Delegate GetOnScroll_IHandler ()
		{
			if (cb_onScroll_I == null)
				cb_onScroll_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnScroll_I);
			return cb_onScroll_I;
		}

		static void n_OnScroll_I (IntPtr jnienv, IntPtr native__this, int mFirstUIItemPosition)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnScroll (mFirstUIItemPosition);
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='onScroll' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onScroll", "(I)V", "GetOnScroll_IHandler")]
		public virtual unsafe void OnScroll (int mFirstUIItemPosition)
		{
			if (id_onScroll_I == IntPtr.Zero)
				id_onScroll_I = JNIEnv.GetMethodID (class_ref, "onScroll", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mFirstUIItemPosition);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScroll_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeListener;
#pragma warning disable 0169
		static Delegate GetRemoveListenerHandler ()
		{
			if (cb_removeListener == null)
				cb_removeListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveListener);
			return cb_removeListener;
		}

		static void n_RemoveListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener ();
		}
#pragma warning restore 0169

		static IntPtr id_removeListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='removeListener' and count(parameter)=0]"
		[Register ("removeListener", "()V", "GetRemoveListenerHandler")]
		public virtual unsafe void RemoveListener ()
		{
			if (id_removeListener == IntPtr.Zero)
				id_removeListener = JNIEnv.GetMethodID (class_ref, "removeListener", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeQuickRepliesMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveQuickRepliesMessage_Ljava_lang_String_Handler ()
		{
			if (cb_removeQuickRepliesMessage_Ljava_lang_String_ == null)
				cb_removeQuickRepliesMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveQuickRepliesMessage_Ljava_lang_String_);
			return cb_removeQuickRepliesMessage_Ljava_lang_String_;
		}

		static void n_RemoveQuickRepliesMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conversationId)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string conversationId = JNIEnv.GetString (native_conversationId, JniHandleOwnership.DoNotTransfer);
			__this.RemoveQuickRepliesMessage (conversationId);
		}
#pragma warning restore 0169

		static IntPtr id_removeQuickRepliesMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='removeQuickRepliesMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeQuickRepliesMessage", "(Ljava/lang/String;)V", "GetRemoveQuickRepliesMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveQuickRepliesMessage (string conversationId)
		{
			if (id_removeQuickRepliesMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_removeQuickRepliesMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeQuickRepliesMessage", "(Ljava/lang/String;)V");
			IntPtr native_conversationId = JNIEnv.NewString (conversationId);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_conversationId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeQuickRepliesMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeQuickRepliesMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_conversationId);
			}
		}

		static Delegate cb_setNumOfUnreadAgentMessages_I;
#pragma warning disable 0169
		static Delegate GetSetNumOfUnreadAgentMessages_IHandler ()
		{
			if (cb_setNumOfUnreadAgentMessages_I == null)
				cb_setNumOfUnreadAgentMessages_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumOfUnreadAgentMessages_I);
			return cb_setNumOfUnreadAgentMessages_I;
		}

		static void n_SetNumOfUnreadAgentMessages_I (IntPtr jnienv, IntPtr native__this, int numOfUnreadMessages)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNumOfUnreadAgentMessages (numOfUnreadMessages);
		}
#pragma warning restore 0169

		static IntPtr id_setNumOfUnreadAgentMessages_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='setNumOfUnreadAgentMessages' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNumOfUnreadAgentMessages", "(I)V", "GetSetNumOfUnreadAgentMessages_IHandler")]
		public virtual unsafe void SetNumOfUnreadAgentMessages (int numOfUnreadMessages)
		{
			if (id_setNumOfUnreadAgentMessages_I == IntPtr.Zero)
				id_setNumOfUnreadAgentMessages_I = JNIEnv.GetMethodID (class_ref, "setNumOfUnreadAgentMessages", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (numOfUnreadMessages);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumOfUnreadAgentMessages_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumOfUnreadAgentMessages", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setQuickRepliesMessageShown_Z;
#pragma warning disable 0169
		static Delegate GetSetQuickRepliesMessageShown_ZHandler ()
		{
			if (cb_setQuickRepliesMessageShown_Z == null)
				cb_setQuickRepliesMessageShown_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetQuickRepliesMessageShown_Z);
			return cb_setQuickRepliesMessageShown_Z;
		}

		static void n_SetQuickRepliesMessageShown_Z (IntPtr jnienv, IntPtr native__this, bool deleteFromSharedPrefs)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQuickRepliesMessageShown (deleteFromSharedPrefs);
		}
#pragma warning restore 0169

		static IntPtr id_setQuickRepliesMessageShown_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='setQuickRepliesMessageShown' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setQuickRepliesMessageShown", "(Z)V", "GetSetQuickRepliesMessageShown_ZHandler")]
		public virtual unsafe void SetQuickRepliesMessageShown (bool deleteFromSharedPrefs)
		{
			if (id_setQuickRepliesMessageShown_Z == IntPtr.Zero)
				id_setQuickRepliesMessageShown_Z = JNIEnv.GetMethodID (class_ref, "setQuickRepliesMessageShown", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (deleteFromSharedPrefs);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQuickRepliesMessageShown_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuickRepliesMessageShown", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.MessagesAsListLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.uicomponents.list']/class[@name='MessagesAsListLoader']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

	}
}
