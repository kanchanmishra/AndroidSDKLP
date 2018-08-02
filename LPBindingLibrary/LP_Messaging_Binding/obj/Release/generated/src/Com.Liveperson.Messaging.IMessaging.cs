using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']"
	[Register ("com/liveperson/messaging/IMessaging", "", "Com.Liveperson.Messaging.IMessagingInvoker")]
	public partial interface IMessaging : IJavaObject {

		bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='changeChatState' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.model.types.ChatState']]"
		[Register ("changeChatState", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/model/types/ChatState;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "GetChangeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		global::Com.Liveperson.Messaging.ConversationActionFailedReason ChangeChatState (string p0, string p1, global::Com.Liveperson.Infra.Model.Types.ChatState p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='checkActiveConversation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;java.lang.Boolean, java.lang.Exception&gt;']]"
		[Register ("checkActiveConversation", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetCheckActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void CheckActiveConversation (string p0, global::Com.Liveperson.Infra.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='checkAgentID' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;com.liveperson.messaging.model.AgentData, java.lang.Exception&gt;']]"
		[Register ("checkAgentID", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetCheckAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void CheckAgentID (string p0, global::Com.Liveperson.Infra.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='checkConversationIsMarkedAsUrgent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.ICallback&lt;java.lang.Boolean, java.lang.Exception&gt;']]"
		[Register ("checkConversationIsMarkedAsUrgent", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetCheckConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void CheckConversationIsMarkedAsUrgent (string p0, global::Com.Liveperson.Infra.ICallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='clearHistory' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearHistory", "(Ljava/lang/String;)Z", "GetClearHistory_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		bool ClearHistory (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V", "GetConnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void Connect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='connect' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams'] and parameter[4][@type='boolean']]"
		[Register ("connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;Z)V", "GetConnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ZHandler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void Connect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void Disconnect (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='downloadFile' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='long'] and parameter[6][@type='long']]"
		[Register ("downloadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V", "GetDownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJHandler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void DownloadFile (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, long p4, long p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='generateUploadToken' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("generateUploadToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetGenerateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void GenerateUploadToken (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='getMaskedMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMaskedMessage", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/utils/MaskedMessage;", "GetGetMaskedMessage_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		global::Com.Liveperson.Infra.Utils.MaskedMessage GetMaskedMessage (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='getUnreadMessagesCount' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.ICallback&lt;java.lang.Integer, java.lang.Exception&gt;']]"
		[Register ("getUnreadMessagesCount", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V", "GetGetUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void GetUnreadMessagesCount (string p0, string p1, global::Com.Liveperson.Infra.ICallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.callbacks.InitLivePersonCallBack']]"
		[Register ("init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V", "GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void Init (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.statemachine.InitProcess']]"
		[Register ("init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V", "GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void Init (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Statemachine.InitProcess p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='isSocketOpen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSocketOpen", "(Ljava/lang/String;)Z", "GetIsSocketOpen_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		bool IsSocketOpen (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='logout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.callbacks.LogoutLivePersonCallBack']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;)V", "GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='logout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.messaging.MessagingInitData'] and parameter[3][@type='com.liveperson.infra.statemachine.LogoutProcess']]"
		[Register ("logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V", "GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Statemachine.LogoutProcess p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='markConversationAsNormal' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("markConversationAsNormal", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "GetMarkConversationAsNormal_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		global::Com.Liveperson.Messaging.ConversationActionFailedReason MarkConversationAsNormal (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='markConversationAsUrgent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("markConversationAsUrgent", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "GetMarkConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		global::Com.Liveperson.Messaging.ConversationActionFailedReason MarkConversationAsUrgent (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='moveToBackground' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("moveToBackground", "(Ljava/lang/String;J)V", "GetMoveToBackground_Ljava_lang_String_JHandler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void MoveToBackground (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='moveToForeground' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[3][@type='com.liveperson.infra.ConversationViewParams']]"
		[Register ("moveToForeground", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V", "GetMoveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void MoveToForeground (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='reconnect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.infra.LPAuthenticationParams']]"
		[Register ("reconnect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;)V", "GetReconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void Reconnect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='registerPusher' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.liveperson.infra.LPAuthenticationParams'] and parameter[5][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;']]"
		[Register ("registerPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ICallback;)V", "GetRegisterPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void RegisterPusher (string p0, string p1, string p2, global::Com.Liveperson.Infra.LPAuthenticationParams p3, global::Com.Liveperson.Infra.ICallback p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='removeCallback' and count(parameter)=0]"
		[Register ("removeCallback", "()V", "GetRemoveCallbackHandler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void RemoveCallback ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='removeMultipleOlderImages' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("removeMultipleOlderImages", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetRemoveMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void RemoveMultipleOlderImages (global::Android.Content.Context p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='resendMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register ("resendMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I", "GetResendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		int ResendMessage (string p0, string p1, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='resendMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType']]"
		[Register ("resendMessage", "(Ljava/lang/String;Ljava/lang/String;JLcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I", "GetResendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		int ResendMessage (string p0, string p1, long p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='resolveConversation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("resolveConversation", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;", "GetResolveConversation_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		global::Com.Liveperson.Messaging.ConversationActionFailedReason ResolveConversation (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='sendCSAT' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("sendCSAT", "(Ljava/lang/String;Ljava/lang/String;II)V", "GetSendCSAT_Ljava_lang_String_Ljava_lang_String_IIHandler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void SendCSAT (string p0, string p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='sendFileMessage' and count(parameter)=6 and parameter[1][@type='com.liveperson.messaging.background.filesharing.FileSharingType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register ("sendFileMessage", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "GetSendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void SendFileMessage (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, string p4, bool p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='sendFormSubmissionMessageCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendFormSubmissionMessageCommand", "(Ljava/lang/String;)V", "GetSendFormSubmissionMessageCommand_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void SendFormSubmissionMessageCommand (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void SendMessage (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='sendMessageWithURL' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void SendMessageWithURL (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='sendUserProfile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.liveperson.messaging.model.UserProfileBundle']]"
		[Register ("sendUserProfile", "(Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V", "GetSendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void SendUserProfile (string p0, global::Com.Liveperson.Messaging.Model.UserProfileBundle p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='serviceStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("serviceStarted", "(Ljava/lang/String;)V", "GetServiceStarted_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void ServiceStarted (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='serviceStopped' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("serviceStopped", "(Ljava/lang/String;)V", "GetServiceStopped_Ljava_lang_String_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void ServiceStopped (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.liveperson.api.LivePersonCallback']]"
		[Register ("setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V", "GetSetCallback_Lcom_liveperson_api_LivePersonCallback_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void SetCallback (global::Com.Liveperson.Api.ILivePersonCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='shutDown' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.statemachine.ShutDownProcess']]"
		[Register ("shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V", "GetShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void ShutDown (global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='unregisterPusher' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.infra.ICallback&lt;java.lang.Void, java.lang.Exception&gt;'] and parameter[4][@type='boolean']]"
		[Register ("unregisterPusher", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V", "GetUnregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ZHandler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void UnregisterPusher (string p0, string p1, global::Com.Liveperson.Infra.ICallback p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging']/interface[@name='IMessaging']/method[@name='updateMessage' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageType'] and parameter[4][@type='com.liveperson.messaging.model.MessagingChatMessage.MessageState']]"
		[Register ("updateMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V", "GetUpdateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler:Com.Liveperson.Messaging.IMessagingInvoker, LP_Messaging_Binding")]
		void UpdateMessage (string p0, string p1, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3);

	}

	[global::Android.Runtime.Register ("com/liveperson/messaging/IMessaging", DoNotGenerateAcw=true)]
	internal class IMessagingInvoker : global::Java.Lang.Object, IMessaging {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/messaging/IMessaging");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessagingInvoker); }
		}

		IntPtr class_ref;

		public static IMessaging GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessaging> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.messaging.IMessaging"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessagingInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
			}
		}

		static Delegate cb_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_;
#pragma warning disable 0169
		static Delegate GetChangeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_Handler ()
		{
			if (cb_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ == null)
				cb_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ChangeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_);
			return cb_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_;
		}

		static IntPtr n_ChangeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Model.Types.ChatState p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Model.Types.ChatState> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ChangeChatState (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_;
		public unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason ChangeChatState (string p0, string p1, global::Com.Liveperson.Infra.Model.Types.ChatState p2)
		{
			if (id_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ == IntPtr.Zero)
				id_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_ = JNIEnv.GetMethodID (class_ref, "changeChatState", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/model/types/ChatState;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_changeChatState_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_model_types_ChatState_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetCheckActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_CheckActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p1 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckActiveConversation (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		public unsafe void CheckActiveConversation (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "checkActiveConversation", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkActiveConversation_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetCheckAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_CheckAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p1 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckAgentID (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		public unsafe void CheckAgentID (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "checkAgentID", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkAgentID_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetCheckConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_CheckConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p1 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckConversationIsMarkedAsUrgent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		public unsafe void CheckConversationIsMarkedAsUrgent (string p0, global::Com.Liveperson.Infra.ICallback p1)
		{
			if (id_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "checkConversationIsMarkedAsUrgent", "(Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkConversationIsMarkedAsUrgent_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_clearHistory_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearHistory_Ljava_lang_String_Handler ()
		{
			if (cb_clearHistory_Ljava_lang_String_ == null)
				cb_clearHistory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ClearHistory_Ljava_lang_String_);
			return cb_clearHistory_Ljava_lang_String_;
		}

		static bool n_ClearHistory_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ClearHistory (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_clearHistory_Ljava_lang_String_;
		public unsafe bool ClearHistory (string p0)
		{
			if (id_clearHistory_Ljava_lang_String_ == IntPtr.Zero)
				id_clearHistory_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearHistory", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clearHistory_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler ()
		{
			if (cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == null)
				cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_);
			return cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		}

		static void n_Connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		public unsafe void Connect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2)
		{
			if (id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ZHandler ()
		{
			if (cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z == null)
				cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z);
			return cb_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z;
		}

		static void n_Connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z;
		public unsafe void Connect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2, bool p3)
		{
			if (id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z == IntPtr.Zero)
				id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_disconnect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_ == null)
				cb_disconnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_String_);
			return cb_disconnect_Ljava_lang_String_;
		}

		static void n_Disconnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		IntPtr id_disconnect_Ljava_lang_String_;
		public unsafe void Disconnect (string p0)
		{
			if (id_disconnect_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetDownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJHandler ()
		{
			if (cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ == null)
				cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, long, long>) n_DownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ);
			return cb_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
		}

		static void n_DownloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, long p4, long p5)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DownloadFile (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ;
		public unsafe void DownloadFile (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, long p4, long p5)
		{
			if (id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ == IntPtr.Zero)
				id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "downloadFile", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_downloadFile_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJ, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_GenerateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GenerateUploadToken (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void GenerateUploadToken (string p0, string p1, string p2)
		{
			if (id_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateUploadToken", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_generateUploadToken_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMaskedMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMaskedMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetMaskedMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMaskedMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Liveperson.Infra.Utils.MaskedMessage GetMaskedMessage (string p0, string p1)
		{
			if (id_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMaskedMessage", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/infra/utils/MaskedMessage;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Com.Liveperson.Infra.Utils.MaskedMessage __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Utils.MaskedMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaskedMessage_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetGetUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == null)
				cb_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_);
			return cb_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		}

		static void n_GetUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p2 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetUnreadMessagesCount (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_;
		public unsafe void GetUnreadMessagesCount (string p0, string p1, global::Com.Liveperson.Infra.ICallback p2)
		{
			if (id_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "getUnreadMessagesCount", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadMessagesCount_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == null)
				cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_);
			return cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		}

		static void n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p2 = (global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_;
		public unsafe void Init (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBack p2)
		{
			if (id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/InitLivePersonCallBack;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_InitLivePersonCallBack_, __args);
		}

		static Delegate cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ == null)
				cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_);
			return cb_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
		}

		static void n_Init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.InitProcess p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.InitProcess> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_;
		public unsafe void Init (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Statemachine.InitProcess p2)
		{
			if (id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_ = JNIEnv.GetMethodID (class_ref, "init", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/InitProcess;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_InitProcess_, __args);
		}

		static Delegate cb_isSocketOpen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsSocketOpen_Ljava_lang_String_Handler ()
		{
			if (cb_isSocketOpen_Ljava_lang_String_ == null)
				cb_isSocketOpen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSocketOpen_Ljava_lang_String_);
			return cb_isSocketOpen_Ljava_lang_String_;
		}

		static bool n_IsSocketOpen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSocketOpen (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isSocketOpen_Ljava_lang_String_;
		public unsafe bool IsSocketOpen (string p0)
		{
			if (id_isSocketOpen_Ljava_lang_String_ == IntPtr.Zero)
				id_isSocketOpen_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isSocketOpen", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSocketOpen_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_Handler ()
		{
			if (cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ == null)
				cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_);
			return cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
		}

		static void n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack p2 = (global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_;
		public unsafe void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Callbacks.ILogoutLivePersonCallBack p2)
		{
			if (id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/callbacks/LogoutLivePersonCallBack;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_callbacks_LogoutLivePersonCallBack_, __args);
		}

		static Delegate cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
#pragma warning disable 0169
		static Delegate GetLogout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_Handler ()
		{
			if (cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ == null)
				cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_);
			return cb_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		}

		static void n_Logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.MessagingInitData p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.MessagingInitData> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.LogoutProcess p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.LogoutProcess> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Logout (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_;
		public unsafe void Logout (global::Android.Content.Context p0, global::Com.Liveperson.Messaging.MessagingInitData p1, global::Com.Liveperson.Infra.Statemachine.LogoutProcess p2)
		{
			if (id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ == IntPtr.Zero)
				id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_ = JNIEnv.GetMethodID (class_ref, "logout", "(Landroid/content/Context;Lcom/liveperson/messaging/MessagingInitData;Lcom/liveperson/infra/statemachine/LogoutProcess;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logout_Landroid_content_Context_Lcom_liveperson_messaging_MessagingInitData_Lcom_liveperson_infra_statemachine_LogoutProcess_, __args);
		}

		static Delegate cb_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMarkConversationAsNormal_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MarkConversationAsNormal_Ljava_lang_String_Ljava_lang_String_);
			return cb_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_MarkConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MarkConversationAsNormal (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason MarkConversationAsNormal (string p0, string p1)
		{
			if (id_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "markConversationAsNormal", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_markConversationAsNormal_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMarkConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MarkConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_);
			return cb_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_MarkConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MarkConversationAsUrgent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason MarkConversationAsUrgent (string p0, string p1)
		{
			if (id_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "markConversationAsUrgent", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_markConversationAsUrgent_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_moveToBackground_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetMoveToBackground_Ljava_lang_String_JHandler ()
		{
			if (cb_moveToBackground_Ljava_lang_String_J == null)
				cb_moveToBackground_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_MoveToBackground_Ljava_lang_String_J);
			return cb_moveToBackground_Ljava_lang_String_J;
		}

		static void n_MoveToBackground_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveToBackground (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_moveToBackground_Ljava_lang_String_J;
		public unsafe void MoveToBackground (string p0, long p1)
		{
			if (id_moveToBackground_Ljava_lang_String_J == IntPtr.Zero)
				id_moveToBackground_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "moveToBackground", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToBackground_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
#pragma warning disable 0169
		static Delegate GetMoveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_Handler ()
		{
			if (cb_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == null)
				cb_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MoveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_);
			return cb_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		}

		static void n_MoveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ConversationViewParams p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.MoveToForeground (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_;
		public unsafe void MoveToForeground (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1, global::Com.Liveperson.Infra.ConversationViewParams p2)
		{
			if (id_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ == IntPtr.Zero)
				id_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_ = JNIEnv.GetMethodID (class_ref, "moveToForeground", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ConversationViewParams;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveToForeground_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ConversationViewParams_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
#pragma warning disable 0169
		static Delegate GetReconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Handler ()
		{
			if (cb_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ == null)
				cb_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_);
			return cb_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
		}

		static void n_Reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Reconnect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_;
		public unsafe void Reconnect (string p0, global::Com.Liveperson.Infra.LPAuthenticationParams p1)
		{
			if (id_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ == IntPtr.Zero)
				id_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_ = JNIEnv.GetMethodID (class_ref, "reconnect", "(Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reconnect_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_;
#pragma warning disable 0169
		static Delegate GetRegisterPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_Handler ()
		{
			if (cb_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ == null)
				cb_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_);
			return cb_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_;
		}

		static void n_RegisterPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPAuthenticationParams p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPAuthenticationParams> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p4 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.RegisterPusher (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_;
		public unsafe void RegisterPusher (string p0, string p1, string p2, global::Com.Liveperson.Infra.LPAuthenticationParams p3, global::Com.Liveperson.Infra.ICallback p4)
		{
			if (id_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ == IntPtr.Zero)
				id_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_ = JNIEnv.GetMethodID (class_ref, "registerPusher", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/LPAuthenticationParams;Lcom/liveperson/infra/ICallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerPusher_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_LPAuthenticationParams_Lcom_liveperson_infra_ICallback_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_removeCallback;
#pragma warning disable 0169
		static Delegate GetRemoveCallbackHandler ()
		{
			if (cb_removeCallback == null)
				cb_removeCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveCallback);
			return cb_removeCallback;
		}

		static void n_RemoveCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback ();
		}
#pragma warning restore 0169

		IntPtr id_removeCallback;
		public unsafe void RemoveCallback ()
		{
			if (id_removeCallback == IntPtr.Zero)
				id_removeCallback = JNIEnv.GetMethodID (class_ref, "removeCallback", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback);
		}

		static Delegate cb_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RemoveMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMultipleOlderImages (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void RemoveMultipleOlderImages (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMultipleOlderImages", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMultipleOlderImages_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
#pragma warning disable 0169
		static Delegate GetResendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler ()
		{
			if (cb_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == null)
				cb_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ResendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_);
			return cb_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		}

		static int n_ResendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResendMessage (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		public unsafe int ResendMessage (string p0, string p1, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2)
		{
			if (id_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
				id_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "resendMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resendMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
#pragma warning disable 0169
		static Delegate GetResendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Handler ()
		{
			if (cb_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == null)
				cb_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr, int>) n_ResendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_);
			return cb_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		}

		static int n_ResendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResendMessage (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_;
		public unsafe int ResendMessage (string p0, string p1, long p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p3)
		{
			if (id_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ == IntPtr.Zero)
				id_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_ = JNIEnv.GetMethodID (class_ref, "resendMessage", "(Ljava/lang/String;Ljava/lang/String;JLcom/liveperson/messaging/model/MessagingChatMessage$MessageType;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_resendMessage_Ljava_lang_String_Ljava_lang_String_JLcom_liveperson_messaging_model_MessagingChatMessage_MessageType_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_resolveConversation_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetResolveConversation_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_resolveConversation_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_resolveConversation_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ResolveConversation_Ljava_lang_String_Ljava_lang_String_);
			return cb_resolveConversation_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ResolveConversation_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResolveConversation (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_resolveConversation_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.Liveperson.Messaging.ConversationActionFailedReason ResolveConversation (string p0, string p1)
		{
			if (id_resolveConversation_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_resolveConversation_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "resolveConversation", "(Ljava/lang/String;Ljava/lang/String;)Lcom/liveperson/messaging/ConversationActionFailedReason;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Com.Liveperson.Messaging.ConversationActionFailedReason __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.ConversationActionFailedReason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_resolveConversation_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_sendCSAT_Ljava_lang_String_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetSendCSAT_Ljava_lang_String_Ljava_lang_String_IIHandler ()
		{
			if (cb_sendCSAT_Ljava_lang_String_Ljava_lang_String_II == null)
				cb_sendCSAT_Ljava_lang_String_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_SendCSAT_Ljava_lang_String_Ljava_lang_String_II);
			return cb_sendCSAT_Ljava_lang_String_Ljava_lang_String_II;
		}

		static void n_SendCSAT_Ljava_lang_String_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendCSAT (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_sendCSAT_Ljava_lang_String_Ljava_lang_String_II;
		public unsafe void SendCSAT (string p0, string p1, int p2, int p3)
		{
			if (id_sendCSAT_Ljava_lang_String_Ljava_lang_String_II == IntPtr.Zero)
				id_sendCSAT_Ljava_lang_String_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "sendCSAT", "(Ljava/lang/String;Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCSAT_Ljava_lang_String_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_SendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SendFileMessage (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		public unsafe void SendFileMessage (global::Com.Liveperson.Messaging.Background.Filesharing.FileSharingType p0, string p1, string p2, string p3, string p4, bool p5)
		{
			if (id_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "sendFileMessage", "(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFileMessage_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_sendFormSubmissionMessageCommand_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendFormSubmissionMessageCommand_Ljava_lang_String_Handler ()
		{
			if (cb_sendFormSubmissionMessageCommand_Ljava_lang_String_ == null)
				cb_sendFormSubmissionMessageCommand_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendFormSubmissionMessageCommand_Ljava_lang_String_);
			return cb_sendFormSubmissionMessageCommand_Ljava_lang_String_;
		}

		static void n_SendFormSubmissionMessageCommand_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendFormSubmissionMessageCommand (p0);
		}
#pragma warning restore 0169

		IntPtr id_sendFormSubmissionMessageCommand_Ljava_lang_String_;
		public unsafe void SendFormSubmissionMessageCommand (string p0)
		{
			if (id_sendFormSubmissionMessageCommand_Ljava_lang_String_ == IntPtr.Zero)
				id_sendFormSubmissionMessageCommand_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendFormSubmissionMessageCommand", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendFormSubmissionMessageCommand_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SendMessage (string p0, string p1, string p2)
		{
			if (id_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageWithURL (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		IntPtr id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SendMessageWithURL (string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7)
		{
			if (id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendMessageWithURL", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (native_p7);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageWithURL_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
			JNIEnv.DeleteLocalRef (native_p7);
		}

		static Delegate cb_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_;
#pragma warning disable 0169
		static Delegate GetSendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_Handler ()
		{
			if (cb_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ == null)
				cb_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_);
			return cb_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_;
		}

		static void n_SendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.UserProfileBundle p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.UserProfileBundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendUserProfile (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_;
		public unsafe void SendUserProfile (string p0, global::Com.Liveperson.Messaging.Model.UserProfileBundle p1)
		{
			if (id_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ == IntPtr.Zero)
				id_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_ = JNIEnv.GetMethodID (class_ref, "sendUserProfile", "(Ljava/lang/String;Lcom/liveperson/messaging/model/UserProfileBundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendUserProfile_Ljava_lang_String_Lcom_liveperson_messaging_model_UserProfileBundle_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_serviceStarted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetServiceStarted_Ljava_lang_String_Handler ()
		{
			if (cb_serviceStarted_Ljava_lang_String_ == null)
				cb_serviceStarted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ServiceStarted_Ljava_lang_String_);
			return cb_serviceStarted_Ljava_lang_String_;
		}

		static void n_ServiceStarted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_serviceStarted_Ljava_lang_String_;
		public unsafe void ServiceStarted (string p0)
		{
			if (id_serviceStarted_Ljava_lang_String_ == IntPtr.Zero)
				id_serviceStarted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "serviceStarted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serviceStarted_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_serviceStopped_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetServiceStopped_Ljava_lang_String_Handler ()
		{
			if (cb_serviceStopped_Ljava_lang_String_ == null)
				cb_serviceStopped_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ServiceStopped_Ljava_lang_String_);
			return cb_serviceStopped_Ljava_lang_String_;
		}

		static void n_ServiceStopped_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServiceStopped (p0);
		}
#pragma warning restore 0169

		IntPtr id_serviceStopped_Ljava_lang_String_;
		public unsafe void ServiceStopped (string p0)
		{
			if (id_serviceStopped_Ljava_lang_String_ == IntPtr.Zero)
				id_serviceStopped_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "serviceStopped", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serviceStopped_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setCallback_Lcom_liveperson_api_LivePersonCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_liveperson_api_LivePersonCallback_Handler ()
		{
			if (cb_setCallback_Lcom_liveperson_api_LivePersonCallback_ == null)
				cb_setCallback_Lcom_liveperson_api_LivePersonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_liveperson_api_LivePersonCallback_);
			return cb_setCallback_Lcom_liveperson_api_LivePersonCallback_;
		}

		static void n_SetCallback_Lcom_liveperson_api_LivePersonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Api.ILivePersonCallback p0 = (global::Com.Liveperson.Api.ILivePersonCallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.ILivePersonCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCallback_Lcom_liveperson_api_LivePersonCallback_;
		public unsafe void SetCallback (global::Com.Liveperson.Api.ILivePersonCallback p0)
		{
			if (id_setCallback_Lcom_liveperson_api_LivePersonCallback_ == IntPtr.Zero)
				id_setCallback_Lcom_liveperson_api_LivePersonCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/liveperson/api/LivePersonCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_liveperson_api_LivePersonCallback_, __args);
		}

		static Delegate cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
#pragma warning disable 0169
		static Delegate GetShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_Handler ()
		{
			if (cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == null)
				cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_);
			return cb_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		}

		static void n_ShutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.Statemachine.ShutDownProcess> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShutDown (p0);
		}
#pragma warning restore 0169

		IntPtr id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_;
		public unsafe void ShutDown (global::Com.Liveperson.Infra.Statemachine.ShutDownProcess p0)
		{
			if (id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ == IntPtr.Zero)
				id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_ = JNIEnv.GetMethodID (class_ref, "shutDown", "(Lcom/liveperson/infra/statemachine/ShutDownProcess;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutDown_Lcom_liveperson_infra_statemachine_ShutDownProcess_, __args);
		}

		static Delegate cb_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z;
#pragma warning disable 0169
		static Delegate GetUnregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_ZHandler ()
		{
			if (cb_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z == null)
				cb_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UnregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z);
			return cb_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z;
		}

		static void n_UnregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.ICallback p2 = (global::Com.Liveperson.Infra.ICallback)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ICallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterPusher (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z;
		public unsafe void UnregisterPusher (string p0, string p1, global::Com.Liveperson.Infra.ICallback p2, bool p3)
		{
			if (id_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z == IntPtr.Zero)
				id_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z = JNIEnv.GetMethodID (class_ref, "unregisterPusher", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/infra/ICallback;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterPusher_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_infra_ICallback_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
#pragma warning disable 0169
		static Delegate GetUpdateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_Handler ()
		{
			if (cb_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == null)
				cb_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_);
			return cb_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		}

		static void n_UpdateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Messaging.IMessaging __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.IMessaging> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_;
		public unsafe void UpdateMessage (string p0, string p1, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageType p2, global::Com.Liveperson.Messaging.Model.MessagingChatMessage.MessageState p3)
		{
			if (id_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ == IntPtr.Zero)
				id_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_ = JNIEnv.GetMethodID (class_ref, "updateMessage", "(Ljava/lang/String;Ljava/lang/String;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageType;Lcom/liveperson/messaging/model/MessagingChatMessage$MessageState;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessage_Ljava_lang_String_Ljava_lang_String_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageType_Lcom_liveperson_messaging_model_MessagingChatMessage_MessageState_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
