using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Messaging_ui.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']"
	[global::Android.Runtime.Register ("com/liveperson/infra/messaging_ui/fragment/ConversationFragment", DoNotGenerateAcw=true)]
	public partial class ConversationFragment : global::Com.Liveperson.Infra.UI.View.Screen.BaseFragment, global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConnectable, global::Com.Liveperson.Infra.Messaging_ui.Fragment.INestedFragmentsContainerCallbacks, global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='BUNDLE_CONVERSATION_ID']"
		[Register ("BUNDLE_CONVERSATION_ID")]
		public const string BundleConversationId = (string) "bundle_conversation_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='PICK_PHOTO_FOR_MESSAGE']"
		[Register ("PICK_PHOTO_FOR_MESSAGE")]
		public const int PickPhotoForMessage = (int) 1545;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='REQUEST_TAKE_PHOTO']"
		[Register ("REQUEST_TAKE_PHOTO")]
		public const int RequestTakePhoto = (int) 1546;

		static IntPtr conversationId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='conversationId']"
		[Register ("conversationId")]
		protected string ConversationId {
			get {
				if (conversationId_jfieldId == IntPtr.Zero)
					conversationId_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, conversationId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (conversationId_jfieldId == IntPtr.Zero)
					conversationId_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, conversationId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAgentTypingReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mAgentTypingReceiver']"
		[Register ("mAgentTypingReceiver")]
		protected global::Com.Liveperson.Infra.LocalBroadcastReceiver MAgentTypingReceiver {
			get {
				if (mAgentTypingReceiver_jfieldId == IntPtr.Zero)
					mAgentTypingReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mAgentTypingReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAgentTypingReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAgentTypingReceiver_jfieldId == IntPtr.Zero)
					mAgentTypingReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mAgentTypingReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAgentTypingReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mBrandId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mBrandId']"
		[Register ("mBrandId")]
		protected string MBrandId {
			get {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBrandId_jfieldId == IntPtr.Zero)
					mBrandId_jfieldId = JNIEnv.GetFieldID (class_ref, "mBrandId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBrandId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConnectionReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mConnectionReceiver']"
		[Register ("mConnectionReceiver")]
		protected global::Com.Liveperson.Infra.LocalBroadcastReceiver MConnectionReceiver {
			get {
				if (mConnectionReceiver_jfieldId == IntPtr.Zero)
					mConnectionReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectionReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConnectionReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConnectionReceiver_jfieldId == IntPtr.Zero)
					mConnectionReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mConnectionReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConnectionReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConversationLayout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mConversationLayout']"
		[Register ("mConversationLayout")]
		protected global::Android.Widget.RelativeLayout MConversationLayout {
			get {
				if (mConversationLayout_jfieldId == IntPtr.Zero)
					mConversationLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationLayout", "Landroid/widget/RelativeLayout;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConversationLayout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConversationLayout_jfieldId == IntPtr.Zero)
					mConversationLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationLayout", "Landroid/widget/RelativeLayout;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConversationLayout_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConversationStateChangeReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mConversationStateChangeReceiver']"
		[Register ("mConversationStateChangeReceiver")]
		protected global::Com.Liveperson.Infra.LocalBroadcastReceiver MConversationStateChangeReceiver {
			get {
				if (mConversationStateChangeReceiver_jfieldId == IntPtr.Zero)
					mConversationStateChangeReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationStateChangeReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConversationStateChangeReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConversationStateChangeReceiver_jfieldId == IntPtr.Zero)
					mConversationStateChangeReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationStateChangeReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConversationStateChangeReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConversationViewParams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mConversationViewParams']"
		[Register ("mConversationViewParams")]
		protected global::Com.Liveperson.Infra.ConversationViewParams MConversationViewParams {
			get {
				if (mConversationViewParams_jfieldId == IntPtr.Zero)
					mConversationViewParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationViewParams", "Lcom/liveperson/infra/ConversationViewParams;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConversationViewParams_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConversationViewParams_jfieldId == IntPtr.Zero)
					mConversationViewParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mConversationViewParams", "Lcom/liveperson/infra/ConversationViewParams;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConversationViewParams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCopyBehavior_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mCopyBehavior']"
		[Register ("mCopyBehavior")]
		protected global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior MCopyBehavior {
			get {
				if (mCopyBehavior_jfieldId == IntPtr.Zero)
					mCopyBehavior_jfieldId = JNIEnv.GetFieldID (class_ref, "mCopyBehavior", "Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCopyBehavior_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.View.Adapter.Copybehavior.CopyBehavior> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCopyBehavior_jfieldId == IntPtr.Zero)
					mCopyBehavior_jfieldId = JNIEnv.GetFieldID (class_ref, "mCopyBehavior", "Lcom/liveperson/infra/messaging_ui/view/adapter/copybehavior/CopyBehavior;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCopyBehavior_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mEmptyView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mEmptyView']"
		[Register ("mEmptyView")]
		protected global::Android.Widget.TextView MEmptyView {
			get {
				if (mEmptyView_jfieldId == IntPtr.Zero)
					mEmptyView_jfieldId = JNIEnv.GetFieldID (class_ref, "mEmptyView", "Landroid/widget/TextView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mEmptyView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mEmptyView_jfieldId == IntPtr.Zero)
					mEmptyView_jfieldId = JNIEnv.GetFieldID (class_ref, "mEmptyView", "Landroid/widget/TextView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEmptyView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mEnterMessageLayout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mEnterMessageLayout']"
		[Register ("mEnterMessageLayout")]
		protected global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage MEnterMessageLayout {
			get {
				if (mEnterMessageLayout_jfieldId == IntPtr.Zero)
					mEnterMessageLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnterMessageLayout", "Lcom/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mEnterMessageLayout_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.AmsEnterMessage> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mEnterMessageLayout_jfieldId == IntPtr.Zero)
					mEnterMessageLayout_jfieldId = JNIEnv.GetFieldID (class_ref, "mEnterMessageLayout", "Lcom/liveperson/infra/messaging_ui/uicomponents/AmsEnterMessage;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mEnterMessageLayout_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFeaturesConfiguration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mFeaturesConfiguration']"
		[Register ("mFeaturesConfiguration")]
		protected global::System.Collections.IDictionary MFeaturesConfiguration {
			get {
				if (mFeaturesConfiguration_jfieldId == IntPtr.Zero)
					mFeaturesConfiguration_jfieldId = JNIEnv.GetFieldID (class_ref, "mFeaturesConfiguration", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFeaturesConfiguration_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFeaturesConfiguration_jfieldId == IntPtr.Zero)
					mFeaturesConfiguration_jfieldId = JNIEnv.GetFieldID (class_ref, "mFeaturesConfiguration", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFeaturesConfiguration_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFormStateChangeReceiver_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mFormStateChangeReceiver']"
		[Register ("mFormStateChangeReceiver")]
		protected global::Com.Liveperson.Infra.LocalBroadcastReceiver MFormStateChangeReceiver {
			get {
				if (mFormStateChangeReceiver_jfieldId == IntPtr.Zero)
					mFormStateChangeReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mFormStateChangeReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFormStateChangeReceiver_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFormStateChangeReceiver_jfieldId == IntPtr.Zero)
					mFormStateChangeReceiver_jfieldId = JNIEnv.GetFieldID (class_ref, "mFormStateChangeReceiver", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFormStateChangeReceiver_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFragmentContainer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mFragmentContainer']"
		[Register ("mFragmentContainer")]
		protected global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks MFragmentContainer {
			get {
				if (mFragmentContainer_jfieldId == IntPtr.Zero)
					mFragmentContainer_jfieldId = JNIEnv.GetFieldID (class_ref, "mFragmentContainer", "Lcom/liveperson/infra/messaging_ui/fragment/ConversationFragmentCallbacks;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFragmentContainer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.IConversationFragmentCallbacks> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFragmentContainer_jfieldId == IntPtr.Zero)
					mFragmentContainer_jfieldId = JNIEnv.GetFieldID (class_ref, "mFragmentContainer", "Lcom/liveperson/infra/messaging_ui/fragment/ConversationFragmentCallbacks;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFragmentContainer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mFullImageFragment_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mFullImageFragment']"
		[Register ("mFullImageFragment")]
		protected global::Com.Liveperson.Infra.Messaging_ui.Fragment.FullImageFragment MFullImageFragment {
			get {
				if (mFullImageFragment_jfieldId == IntPtr.Zero)
					mFullImageFragment_jfieldId = JNIEnv.GetFieldID (class_ref, "mFullImageFragment", "Lcom/liveperson/infra/messaging_ui/fragment/FullImageFragment;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFullImageFragment_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.FullImageFragment> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFullImageFragment_jfieldId == IntPtr.Zero)
					mFullImageFragment_jfieldId = JNIEnv.GetFieldID (class_ref, "mFullImageFragment", "Lcom/liveperson/infra/messaging_ui/fragment/FullImageFragment;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFullImageFragment_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mIConversationProvider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mIConversationProvider']"
		[Register ("mIConversationProvider")]
		protected global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider MIConversationProvider {
			get {
				if (mIConversationProvider_jfieldId == IntPtr.Zero)
					mIConversationProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mIConversationProvider", "Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mIConversationProvider_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Uicomponents.IConversationProvider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mIConversationProvider_jfieldId == IntPtr.Zero)
					mIConversationProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mIConversationProvider", "Lcom/liveperson/infra/ui/view/uicomponents/IConversationProvider;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mIConversationProvider_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mInlineMessagesController_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mInlineMessagesController']"
		[Register ("mInlineMessagesController")]
		protected global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController MInlineMessagesController {
			get {
				if (mInlineMessagesController_jfieldId == IntPtr.Zero)
					mInlineMessagesController_jfieldId = JNIEnv.GetFieldID (class_ref, "mInlineMessagesController", "Lcom/liveperson/infra/messaging_ui/uicomponents/inlinemessages/InlineMessagesController;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mInlineMessagesController_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.Inlinemessages.InlineMessagesController> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mInlineMessagesController_jfieldId == IntPtr.Zero)
					mInlineMessagesController_jfieldId = JNIEnv.GetFieldID (class_ref, "mInlineMessagesController", "Lcom/liveperson/infra/messaging_ui/uicomponents/inlinemessages/InlineMessagesController;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mInlineMessagesController_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mLPAuthenticationParams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mLPAuthenticationParams']"
		[Register ("mLPAuthenticationParams")]
		protected global::Com.Liveperson.Infra.LPAuthenticationParams MLPAuthenticationParams {
			get {
				if (mLPAuthenticationParams_jfieldId == IntPtr.Zero)
					mLPAuthenticationParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mLPAuthenticationParams", "Lcom/liveperson/infra/LPAuthenticationParams;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mLPAuthenticationParams_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLPAuthenticationParams_jfieldId == IntPtr.Zero)
					mLPAuthenticationParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mLPAuthenticationParams", "Lcom/liveperson/infra/LPAuthenticationParams;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mLPAuthenticationParams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRecyclerView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mRecyclerView']"
		[Register ("mRecyclerView")]
		protected global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView MRecyclerView {
			get {
				if (mRecyclerView_jfieldId == IntPtr.Zero)
					mRecyclerView_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecyclerView", "Lcom/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageListRecyclerView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRecyclerView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.ChatMessageListRecyclerView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRecyclerView_jfieldId == IntPtr.Zero)
					mRecyclerView_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecyclerView", "Lcom/liveperson/infra/messaging_ui/uicomponents/list/ChatMessageListRecyclerView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRecyclerView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mUnAuthenticatedUserExpired_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/field[@name='mUnAuthenticatedUserExpired']"
		[Register ("mUnAuthenticatedUserExpired")]
		protected global::Com.Liveperson.Infra.LocalBroadcastReceiver MUnAuthenticatedUserExpired {
			get {
				if (mUnAuthenticatedUserExpired_jfieldId == IntPtr.Zero)
					mUnAuthenticatedUserExpired_jfieldId = JNIEnv.GetFieldID (class_ref, "mUnAuthenticatedUserExpired", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mUnAuthenticatedUserExpired_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LocalBroadcastReceiver> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUnAuthenticatedUserExpired_jfieldId == IntPtr.Zero)
					mUnAuthenticatedUserExpired_jfieldId = JNIEnv.GetFieldID (class_ref, "mUnAuthenticatedUserExpired", "Lcom/liveperson/infra/LocalBroadcastReceiver;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mUnAuthenticatedUserExpired_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/messaging_ui/fragment/ConversationFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationFragment); }
		}

		protected ConversationFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/constructor[@name='ConversationFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationFragment)) {
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

		static Delegate cb_attachActivity_Landroid_support_v4_app_FragmentActivity_;
#pragma warning disable 0169
		static Delegate GetAttachActivity_Landroid_support_v4_app_FragmentActivity_Handler ()
		{
			if (cb_attachActivity_Landroid_support_v4_app_FragmentActivity_ == null)
				cb_attachActivity_Landroid_support_v4_app_FragmentActivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AttachActivity_Landroid_support_v4_app_FragmentActivity_);
			return cb_attachActivity_Landroid_support_v4_app_FragmentActivity_;
		}

		static void n_AttachActivity_Landroid_support_v4_app_FragmentActivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Support.V4.App.FragmentActivity p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V4.App.FragmentActivity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AttachActivity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_attachActivity_Landroid_support_v4_app_FragmentActivity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='attachActivity' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.FragmentActivity']]"
		[Register ("attachActivity", "(Landroid/support/v4/app/FragmentActivity;)V", "GetAttachActivity_Landroid_support_v4_app_FragmentActivity_Handler")]
		protected virtual unsafe void AttachActivity (global::Android.Support.V4.App.FragmentActivity p0)
		{
			if (id_attachActivity_Landroid_support_v4_app_FragmentActivity_ == IntPtr.Zero)
				id_attachActivity_Landroid_support_v4_app_FragmentActivity_ = JNIEnv.GetMethodID (class_ref, "attachActivity", "(Landroid/support/v4/app/FragmentActivity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attachActivity_Landroid_support_v4_app_FragmentActivity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "attachActivity", "(Landroid/support/v4/app/FragmentActivity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static void n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect ();
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "GetConnectHandler")]
		public virtual unsafe void Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "()V"));
			} finally {
			}
		}

		static Delegate cb_handleConversationClosed_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleConversationClosed_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_handleConversationClosed_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_handleConversationClosed_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleConversationClosed_Ljava_lang_String_Ljava_lang_String_);
			return cb_handleConversationClosed_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_HandleConversationClosed_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.HandleConversationClosed (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleConversationClosed_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='handleConversationClosed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("handleConversationClosed", "(Ljava/lang/String;Ljava/lang/String;)V", "GetHandleConversationClosed_Ljava_lang_String_Ljava_lang_String_Handler")]
		protected virtual unsafe void HandleConversationClosed (string p0, string p1)
		{
			if (id_handleConversationClosed_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_handleConversationClosed_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleConversationClosed", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleConversationClosed_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleConversationClosed", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_handleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHandleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_Handler ()
		{
			if (cb_handleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_ == null)
				cb_handleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_HandleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_);
			return cb_handleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_;
		}

		static void n_HandleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.ConversationState p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.ConversationState> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.HandleConversationUpdate (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_handleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='handleConversationUpdate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.api.response.types.ConversationState'] and parameter[3][@type='com.liveperson.api.response.types.CSAT.CSAT_SHOW_STATUS'] and parameter[4][@type='java.lang.String']]"
		[Register ("handleConversationUpdate", "(Ljava/lang/String;Lcom/liveperson/api/response/types/ConversationState;Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;Ljava/lang/String;)V", "GetHandleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_Handler")]
		protected virtual unsafe void HandleConversationUpdate (string p0, global::Com.Liveperson.Api.Response.Types.ConversationState p1, global::Com.Liveperson.Api.Response.Types.CSAT.CSAT_SHOW_STATUS p2, string p3)
		{
			if (id_handleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_ == IntPtr.Zero)
				id_handleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "handleConversationUpdate", "(Ljava/lang/String;Lcom/liveperson/api/response/types/ConversationState;Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleConversationUpdate_Ljava_lang_String_Lcom_liveperson_api_response_types_ConversationState_Lcom_liveperson_api_response_types_CSAT_CSAT_SHOW_STATUS_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleConversationUpdate", "(Ljava/lang/String;Lcom/liveperson/api/response/types/ConversationState;Lcom/liveperson/api/response/types/CSAT$CSAT_SHOW_STATUS;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_initConversationProvider;
#pragma warning disable 0169
		static Delegate GetInitConversationProviderHandler ()
		{
			if (cb_initConversationProvider == null)
				cb_initConversationProvider = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitConversationProvider);
			return cb_initConversationProvider;
		}

		static void n_InitConversationProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitConversationProvider ();
		}
#pragma warning restore 0169

		static IntPtr id_initConversationProvider;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='initConversationProvider' and count(parameter)=0]"
		[Register ("initConversationProvider", "()V", "GetInitConversationProviderHandler")]
		protected virtual unsafe void InitConversationProvider ()
		{
			if (id_initConversationProvider == IntPtr.Zero)
				id_initConversationProvider = JNIEnv.GetMethodID (class_ref, "initConversationProvider", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initConversationProvider);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initConversationProvider", "()V"));
			} finally {
			}
		}

		static Delegate cb_initRecyclerView;
#pragma warning disable 0169
		static Delegate GetInitRecyclerViewHandler ()
		{
			if (cb_initRecyclerView == null)
				cb_initRecyclerView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitRecyclerView);
			return cb_initRecyclerView;
		}

		static void n_InitRecyclerView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitRecyclerView ();
		}
#pragma warning restore 0169

		static IntPtr id_initRecyclerView;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='initRecyclerView' and count(parameter)=0]"
		[Register ("initRecyclerView", "()V", "GetInitRecyclerViewHandler")]
		protected virtual unsafe void InitRecyclerView ()
		{
			if (id_initRecyclerView == IntPtr.Zero)
				id_initRecyclerView = JNIEnv.GetMethodID (class_ref, "initRecyclerView", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initRecyclerView);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initRecyclerView", "()V"));
			} finally {
			}
		}

		static Delegate cb_initRelevantToolbar;
#pragma warning disable 0169
		static Delegate GetInitRelevantToolbarHandler ()
		{
			if (cb_initRelevantToolbar == null)
				cb_initRelevantToolbar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitRelevantToolbar);
			return cb_initRelevantToolbar;
		}

		static void n_InitRelevantToolbar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitRelevantToolbar ();
		}
#pragma warning restore 0169

		static IntPtr id_initRelevantToolbar;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='initRelevantToolbar' and count(parameter)=0]"
		[Register ("initRelevantToolbar", "()V", "GetInitRelevantToolbarHandler")]
		public virtual unsafe void InitRelevantToolbar ()
		{
			if (id_initRelevantToolbar == IntPtr.Zero)
				id_initRelevantToolbar = JNIEnv.GetMethodID (class_ref, "initRelevantToolbar", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initRelevantToolbar);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initRelevantToolbar", "()V"));
			} finally {
			}
		}

		static IntPtr id_newInstance_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_util_HashMap_Lcom_liveperson_infra_ConversationViewParams_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='newInstance' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='java.util.HashMap&lt;java.lang.String, java.lang.Boolean&gt;'] and parameter[4][@type='com.liveperson.infra.ConversationViewParams'] and parameter[5][@type='boolean']]"
		[Register ("newInstance", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/util/HashMap;Lcom/liveperson/infra/ConversationViewParams;Z)Lcom/liveperson/infra/messaging_ui/fragment/ConversationFragment;", "")]
		public static unsafe global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment NewInstance (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> p2, global::Com.Liveperson.Infra.ConversationViewParams p3, bool p4)
		{
			if (id_newInstance_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_util_HashMap_Lcom_liveperson_infra_ConversationViewParams_Z == IntPtr.Zero)
				id_newInstance_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_util_HashMap_Lcom_liveperson_infra_ConversationViewParams_Z = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Ljava/util/HashMap;Lcom/liveperson/infra/ConversationViewParams;Z)Lcom/liveperson/infra/messaging_ui/fragment/ConversationFragment;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Ljava_util_HashMap_Lcom_liveperson_infra_ConversationViewParams_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onBackPressed;
#pragma warning disable 0169
		static Delegate GetOnBackPressedHandler ()
		{
			if (cb_onBackPressed == null)
				cb_onBackPressed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnBackPressed);
			return cb_onBackPressed;
		}

		static bool n_OnBackPressed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnBackPressed ();
		}
#pragma warning restore 0169

		static IntPtr id_onBackPressed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='onBackPressed' and count(parameter)=0]"
		[Register ("onBackPressed", "()Z", "GetOnBackPressedHandler")]
		public virtual unsafe bool OnBackPressed ()
		{
			if (id_onBackPressed == IntPtr.Zero)
				id_onBackPressed = JNIEnv.GetMethodID (class_ref, "onBackPressed", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onBackPressed);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBackPressed", "()Z"));
			} finally {
			}
		}

		static Delegate cb_onConversationResolved_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConversationResolved_Ljava_lang_String_Handler ()
		{
			if (cb_onConversationResolved_Ljava_lang_String_ == null)
				cb_onConversationResolved_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConversationResolved_Ljava_lang_String_);
			return cb_onConversationResolved_Ljava_lang_String_;
		}

		static void n_OnConversationResolved_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConversationResolved (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConversationResolved_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='onConversationResolved' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConversationResolved", "(Ljava/lang/String;)V", "GetOnConversationResolved_Ljava_lang_String_Handler")]
		protected virtual unsafe void OnConversationResolved (string p0)
		{
			if (id_onConversationResolved_Ljava_lang_String_ == IntPtr.Zero)
				id_onConversationResolved_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConversationResolved", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConversationResolved_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConversationResolved", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetOnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJHandler ()
		{
			if (cb_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ == null)
				cb_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, long>) n_OnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ);
			return cb_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ;
		}

		static void n_OnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, long p3, long p4)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnFileClicked (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='onFileClicked' and count(parameter)=5 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register ("onFileClicked", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;JJ)V", "GetOnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJHandler")]
		public virtual unsafe void OnFileClicked (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, long p3, long p4)
		{
			if (id_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ == IntPtr.Zero)
				id_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "onFileClicked", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;JJ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFileClicked", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;JJ)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onSurveySubmitted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSurveySubmitted_Ljava_lang_String_Handler ()
		{
			if (cb_onSurveySubmitted_Ljava_lang_String_ == null)
				cb_onSurveySubmitted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSurveySubmitted_Ljava_lang_String_);
			return cb_onSurveySubmitted_Ljava_lang_String_;
		}

		static void n_OnSurveySubmitted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurveySubmitted (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSurveySubmitted_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='onSurveySubmitted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSurveySubmitted", "(Ljava/lang/String;)V", "GetOnSurveySubmitted_Ljava_lang_String_Handler")]
		public virtual unsafe void OnSurveySubmitted (string p0)
		{
			if (id_onSurveySubmitted_Ljava_lang_String_ == IntPtr.Zero)
				id_onSurveySubmitted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSurveySubmitted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurveySubmitted_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurveySubmitted", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerBroadCastReceivers;
#pragma warning disable 0169
		static Delegate GetRegisterBroadCastReceiversHandler ()
		{
			if (cb_registerBroadCastReceivers == null)
				cb_registerBroadCastReceivers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterBroadCastReceivers);
			return cb_registerBroadCastReceivers;
		}

		static void n_RegisterBroadCastReceivers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterBroadCastReceivers ();
		}
#pragma warning restore 0169

		static IntPtr id_registerBroadCastReceivers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='registerBroadCastReceivers' and count(parameter)=0]"
		[Register ("registerBroadCastReceivers", "()V", "GetRegisterBroadCastReceiversHandler")]
		protected virtual unsafe void RegisterBroadCastReceivers ()
		{
			if (id_registerBroadCastReceivers == IntPtr.Zero)
				id_registerBroadCastReceivers = JNIEnv.GetMethodID (class_ref, "registerBroadCastReceivers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerBroadCastReceivers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerBroadCastReceivers", "()V"));
			} finally {
			}
		}

		static Delegate cb_registerConnectionReceiver;
#pragma warning disable 0169
		static Delegate GetRegisterConnectionReceiverHandler ()
		{
			if (cb_registerConnectionReceiver == null)
				cb_registerConnectionReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterConnectionReceiver);
			return cb_registerConnectionReceiver;
		}

		static void n_RegisterConnectionReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConnectionReceiver ();
		}
#pragma warning restore 0169

		static IntPtr id_registerConnectionReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='registerConnectionReceiver' and count(parameter)=0]"
		[Register ("registerConnectionReceiver", "()V", "GetRegisterConnectionReceiverHandler")]
		protected virtual unsafe void RegisterConnectionReceiver ()
		{
			if (id_registerConnectionReceiver == IntPtr.Zero)
				id_registerConnectionReceiver = JNIEnv.GetMethodID (class_ref, "registerConnectionReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerConnectionReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerConnectionReceiver", "()V"));
			} finally {
			}
		}

		static Delegate cb_registerConversationStateChangedReceiver;
#pragma warning disable 0169
		static Delegate GetRegisterConversationStateChangedReceiverHandler ()
		{
			if (cb_registerConversationStateChangedReceiver == null)
				cb_registerConversationStateChangedReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterConversationStateChangedReceiver);
			return cb_registerConversationStateChangedReceiver;
		}

		static void n_RegisterConversationStateChangedReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterConversationStateChangedReceiver ();
		}
#pragma warning restore 0169

		static IntPtr id_registerConversationStateChangedReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='registerConversationStateChangedReceiver' and count(parameter)=0]"
		[Register ("registerConversationStateChangedReceiver", "()V", "GetRegisterConversationStateChangedReceiverHandler")]
		protected virtual unsafe void RegisterConversationStateChangedReceiver ()
		{
			if (id_registerConversationStateChangedReceiver == IntPtr.Zero)
				id_registerConversationStateChangedReceiver = JNIEnv.GetMethodID (class_ref, "registerConversationStateChangedReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerConversationStateChangedReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerConversationStateChangedReceiver", "()V"));
			} finally {
			}
		}

		static Delegate cb_registerFormStateChangeReceiver;
#pragma warning disable 0169
		static Delegate GetRegisterFormStateChangeReceiverHandler ()
		{
			if (cb_registerFormStateChangeReceiver == null)
				cb_registerFormStateChangeReceiver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterFormStateChangeReceiver);
			return cb_registerFormStateChangeReceiver;
		}

		static void n_RegisterFormStateChangeReceiver (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterFormStateChangeReceiver ();
		}
#pragma warning restore 0169

		static IntPtr id_registerFormStateChangeReceiver;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='registerFormStateChangeReceiver' and count(parameter)=0]"
		[Register ("registerFormStateChangeReceiver", "()V", "GetRegisterFormStateChangeReceiverHandler")]
		protected virtual unsafe void RegisterFormStateChangeReceiver ()
		{
			if (id_registerFormStateChangeReceiver == IntPtr.Zero)
				id_registerFormStateChangeReceiver = JNIEnv.GetMethodID (class_ref, "registerFormStateChangeReceiver", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerFormStateChangeReceiver);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerFormStateChangeReceiver", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendCSAT_II;
#pragma warning disable 0169
		static Delegate GetSendCSAT_IIHandler ()
		{
			if (cb_sendCSAT_II == null)
				cb_sendCSAT_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SendCSAT_II);
			return cb_sendCSAT_II;
		}

		static void n_SendCSAT_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendCSAT (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendCSAT_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='sendCSAT' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("sendCSAT", "(II)V", "GetSendCSAT_IIHandler")]
		public virtual unsafe void SendCSAT (int p0, int p1)
		{
			if (id_sendCSAT_II == IntPtr.Zero)
				id_sendCSAT_II = JNIEnv.GetMethodID (class_ref, "sendCSAT", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCSAT_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCSAT", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSecureFormMode_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecureFormMode_ZLjava_lang_String_Handler ()
		{
			if (cb_setSecureFormMode_ZLjava_lang_String_ == null)
				cb_setSecureFormMode_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SetSecureFormMode_ZLjava_lang_String_);
			return cb_setSecureFormMode_ZLjava_lang_String_;
		}

		static void n_SetSecureFormMode_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSecureFormMode (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSecureFormMode_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='setSecureFormMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSecureFormMode", "(ZLjava/lang/String;)V", "GetSetSecureFormMode_ZLjava_lang_String_Handler")]
		public virtual unsafe void SetSecureFormMode (bool p0, string p1)
		{
			if (id_setSecureFormMode_ZLjava_lang_String_ == IntPtr.Zero)
				id_setSecureFormMode_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecureFormMode", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecureFormMode_ZLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecureFormMode", "(ZLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_slideOutFragment;
#pragma warning disable 0169
		static Delegate GetSlideOutFragmentHandler ()
		{
			if (cb_slideOutFragment == null)
				cb_slideOutFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SlideOutFragment);
			return cb_slideOutFragment;
		}

		static void n_SlideOutFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlideOutFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_slideOutFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='slideOutFragment' and count(parameter)=0]"
		[Register ("slideOutFragment", "()V", "GetSlideOutFragmentHandler")]
		public virtual unsafe void SlideOutFragment ()
		{
			if (id_slideOutFragment == IntPtr.Zero)
				id_slideOutFragment = JNIEnv.GetMethodID (class_ref, "slideOutFragment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_slideOutFragment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "slideOutFragment", "()V"));
			} finally {
			}
		}

		static Delegate cb_slideOutSecureFormFragment;
#pragma warning disable 0169
		static Delegate GetSlideOutSecureFormFragmentHandler ()
		{
			if (cb_slideOutSecureFormFragment == null)
				cb_slideOutSecureFormFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SlideOutSecureFormFragment);
			return cb_slideOutSecureFormFragment;
		}

		static void n_SlideOutSecureFormFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlideOutSecureFormFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_slideOutSecureFormFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='slideOutSecureFormFragment' and count(parameter)=0]"
		[Register ("slideOutSecureFormFragment", "()V", "GetSlideOutSecureFormFragmentHandler")]
		public virtual unsafe void SlideOutSecureFormFragment ()
		{
			if (id_slideOutSecureFormFragment == IntPtr.Zero)
				id_slideOutSecureFormFragment = JNIEnv.GetMethodID (class_ref, "slideOutSecureFormFragment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_slideOutSecureFormFragment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "slideOutSecureFormFragment", "()V"));
			} finally {
			}
		}

		static Delegate cb_startCamera;
#pragma warning disable 0169
		static Delegate GetStartCameraHandler ()
		{
			if (cb_startCamera == null)
				cb_startCamera = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartCamera);
			return cb_startCamera;
		}

		static void n_StartCamera (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartCamera ();
		}
#pragma warning restore 0169

		static IntPtr id_startCamera;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='startCamera' and count(parameter)=0]"
		[Register ("startCamera", "()V", "GetStartCameraHandler")]
		public virtual unsafe void StartCamera ()
		{
			if (id_startCamera == IntPtr.Zero)
				id_startCamera = JNIEnv.GetMethodID (class_ref, "startCamera", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startCamera);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startCamera", "()V"));
			} finally {
			}
		}

		static Delegate cb_unregisterForegroundService;
#pragma warning disable 0169
		static Delegate GetUnregisterForegroundServiceHandler ()
		{
			if (cb_unregisterForegroundService == null)
				cb_unregisterForegroundService = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterForegroundService);
			return cb_unregisterForegroundService;
		}

		static void n_UnregisterForegroundService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterForegroundService ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterForegroundService;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='unregisterForegroundService' and count(parameter)=0]"
		[Register ("unregisterForegroundService", "()V", "GetUnregisterForegroundServiceHandler")]
		protected virtual unsafe void UnregisterForegroundService ()
		{
			if (id_unregisterForegroundService == IntPtr.Zero)
				id_unregisterForegroundService = JNIEnv.GetMethodID (class_ref, "unregisterForegroundService", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterForegroundService);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterForegroundService", "()V"));
			} finally {
			}
		}

		static Delegate cb_unregisterFragment;
#pragma warning disable 0169
		static Delegate GetUnregisterFragmentHandler ()
		{
			if (cb_unregisterFragment == null)
				cb_unregisterFragment = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterFragment);
			return cb_unregisterFragment;
		}

		static void n_UnregisterFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterFragment ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterFragment;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='unregisterFragment' and count(parameter)=0]"
		[Register ("unregisterFragment", "()V", "GetUnregisterFragmentHandler")]
		protected virtual unsafe void UnregisterFragment ()
		{
			if (id_unregisterFragment == IntPtr.Zero)
				id_unregisterFragment = JNIEnv.GetMethodID (class_ref, "unregisterFragment", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterFragment);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterFragment", "()V"));
			} finally {
			}
		}

		static Delegate cb_unregisterReceivers;
#pragma warning disable 0169
		static Delegate GetUnregisterReceiversHandler ()
		{
			if (cb_unregisterReceivers == null)
				cb_unregisterReceivers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterReceivers);
			return cb_unregisterReceivers;
		}

		static void n_UnregisterReceivers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterReceivers ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterReceivers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='unregisterReceivers' and count(parameter)=0]"
		[Register ("unregisterReceivers", "()V", "GetUnregisterReceiversHandler")]
		protected virtual unsafe void UnregisterReceivers ()
		{
			if (id_unregisterReceivers == IntPtr.Zero)
				id_unregisterReceivers = JNIEnv.GetMethodID (class_ref, "unregisterReceivers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterReceivers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterReceivers", "()V"));
			} finally {
			}
		}

		static Delegate cb_verifyCameraPermissions_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetVerifyCameraPermissions_Landroid_app_Activity_Handler ()
		{
			if (cb_verifyCameraPermissions_Landroid_app_Activity_ == null)
				cb_verifyCameraPermissions_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_VerifyCameraPermissions_Landroid_app_Activity_);
			return cb_verifyCameraPermissions_Landroid_app_Activity_;
		}

		static bool n_VerifyCameraPermissions_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.VerifyCameraPermissions (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_verifyCameraPermissions_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='verifyCameraPermissions' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("verifyCameraPermissions", "(Landroid/app/Activity;)Z", "GetVerifyCameraPermissions_Landroid_app_Activity_Handler")]
		public virtual unsafe bool VerifyCameraPermissions (global::Android.App.Activity p0)
		{
			if (id_verifyCameraPermissions_Landroid_app_Activity_ == IntPtr.Zero)
				id_verifyCameraPermissions_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "verifyCameraPermissions", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_verifyCameraPermissions_Landroid_app_Activity_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verifyCameraPermissions", "(Landroid/app/Activity;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_verifyStorageAndRecordPermissions_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetVerifyStorageAndRecordPermissions_Landroid_app_Activity_Handler ()
		{
			if (cb_verifyStorageAndRecordPermissions_Landroid_app_Activity_ == null)
				cb_verifyStorageAndRecordPermissions_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_VerifyStorageAndRecordPermissions_Landroid_app_Activity_);
			return cb_verifyStorageAndRecordPermissions_Landroid_app_Activity_;
		}

		static bool n_VerifyStorageAndRecordPermissions_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.VerifyStorageAndRecordPermissions (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_verifyStorageAndRecordPermissions_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='verifyStorageAndRecordPermissions' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("verifyStorageAndRecordPermissions", "(Landroid/app/Activity;)Z", "GetVerifyStorageAndRecordPermissions_Landroid_app_Activity_Handler")]
		public virtual unsafe bool VerifyStorageAndRecordPermissions (global::Android.App.Activity p0)
		{
			if (id_verifyStorageAndRecordPermissions_Landroid_app_Activity_ == IntPtr.Zero)
				id_verifyStorageAndRecordPermissions_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "verifyStorageAndRecordPermissions", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_verifyStorageAndRecordPermissions_Landroid_app_Activity_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verifyStorageAndRecordPermissions", "(Landroid/app/Activity;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_verifyStoragePermissions_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetVerifyStoragePermissions_Landroid_app_Activity_Handler ()
		{
			if (cb_verifyStoragePermissions_Landroid_app_Activity_ == null)
				cb_verifyStoragePermissions_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_VerifyStoragePermissions_Landroid_app_Activity_);
			return cb_verifyStoragePermissions_Landroid_app_Activity_;
		}

		static bool n_VerifyStoragePermissions_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.VerifyStoragePermissions (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_verifyStoragePermissions_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.messaging_ui.fragment']/class[@name='ConversationFragment']/method[@name='verifyStoragePermissions' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("verifyStoragePermissions", "(Landroid/app/Activity;)Z", "GetVerifyStoragePermissions_Landroid_app_Activity_Handler")]
		public virtual unsafe bool VerifyStoragePermissions (global::Android.App.Activity p0)
		{
			if (id_verifyStoragePermissions_Landroid_app_Activity_ == IntPtr.Zero)
				id_verifyStoragePermissions_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "verifyStoragePermissions", "(Landroid/app/Activity;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_verifyStoragePermissions_Landroid_app_Activity_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verifyStoragePermissions", "(Landroid/app/Activity;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
