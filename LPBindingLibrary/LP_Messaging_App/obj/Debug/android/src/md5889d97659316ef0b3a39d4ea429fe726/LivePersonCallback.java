package md5889d97659316ef0b3a39d4ea429fe726;


public class LivePersonCallback
	extends com.liveperson.api.LivePersonCallbackImpl
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAgentAvatarTapped:(Lcom/liveperson/messaging/model/AgentData;)V:GetOnAgentAvatarTapped_Lcom_liveperson_messaging_model_AgentData_Handler\n" +
			"n_onAgentDetailsChanged:(Lcom/liveperson/messaging/model/AgentData;)V:GetOnAgentDetailsChanged_Lcom_liveperson_messaging_model_AgentData_Handler\n" +
			"n_onAgentTyping:(Z)V:GetOnAgentTyping_ZHandler\n" +
			"n_onConnectionChanged:(Z)V:GetOnConnectionChanged_ZHandler\n" +
			"n_onConversationMarkedAsNormal:()V:GetOnConversationMarkedAsNormalHandler\n" +
			"n_onConversationMarkedAsUrgent:()V:GetOnConversationMarkedAsUrgentHandler\n" +
			"n_onConversationResolved:(Lcom/liveperson/api/sdk/LPConversationData;)V:GetOnConversationResolved_Lcom_liveperson_api_sdk_LPConversationData_Handler\n" +
			"n_onConversationStarted:(Lcom/liveperson/api/sdk/LPConversationData;)V:GetOnConversationStarted_Lcom_liveperson_api_sdk_LPConversationData_Handler\n" +
			"n_onCsatDismissed:()V:GetOnCsatDismissedHandler\n" +
			"n_onCsatLaunched:()V:GetOnCsatLaunchedHandler\n" +
			"n_onCsatSkipped:()V:GetOnCsatSkippedHandler\n" +
			"n_onCsatSubmitted:(Ljava/lang/String;)V:GetOnCsatSubmitted_Ljava_lang_String_Handler\n" +
			"n_onError:(Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V:GetOnError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_Handler\n" +
			"n_onOfflineHoursChanges:(Z)V:GetOnOfflineHoursChanges_ZHandler\n" +
			"n_onStructuredContentLinkClicked:(Ljava/lang/String;)V:GetOnStructuredContentLinkClicked_Ljava_lang_String_Handler\n" +
			"n_onTokenExpired:()V:GetOnTokenExpiredHandler\n" +
			"n_onUnauthenticatedUserExpired:()V:GetOnUnauthenticatedUserExpiredHandler\n" +
			"n_onUserActionOnPreventedPermission:(Lcom/liveperson/api/sdk/PermissionType;)V:GetOnUserActionOnPreventedPermission_Lcom_liveperson_api_sdk_PermissionType_Handler\n" +
			"n_onUserDeniedPermission:(Lcom/liveperson/api/sdk/PermissionType;Z)V:GetOnUserDeniedPermission_Lcom_liveperson_api_sdk_PermissionType_ZHandler\n" +
			"";
		mono.android.Runtime.register ("LP_Messaging_App.LivePersonCallback, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LivePersonCallback.class, __md_methods);
	}


	public LivePersonCallback ()
	{
		super ();
		if (getClass () == LivePersonCallback.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.LivePersonCallback, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public LivePersonCallback (android.content.Context p0)
	{
		super ();
		if (getClass () == LivePersonCallback.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.LivePersonCallback, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onAgentAvatarTapped (com.liveperson.messaging.model.AgentData p0)
	{
		n_onAgentAvatarTapped (p0);
	}

	private native void n_onAgentAvatarTapped (com.liveperson.messaging.model.AgentData p0);


	public void onAgentDetailsChanged (com.liveperson.messaging.model.AgentData p0)
	{
		n_onAgentDetailsChanged (p0);
	}

	private native void n_onAgentDetailsChanged (com.liveperson.messaging.model.AgentData p0);


	public void onAgentTyping (boolean p0)
	{
		n_onAgentTyping (p0);
	}

	private native void n_onAgentTyping (boolean p0);


	public void onConnectionChanged (boolean p0)
	{
		n_onConnectionChanged (p0);
	}

	private native void n_onConnectionChanged (boolean p0);


	public void onConversationMarkedAsNormal ()
	{
		n_onConversationMarkedAsNormal ();
	}

	private native void n_onConversationMarkedAsNormal ();


	public void onConversationMarkedAsUrgent ()
	{
		n_onConversationMarkedAsUrgent ();
	}

	private native void n_onConversationMarkedAsUrgent ();


	public void onConversationResolved (com.liveperson.api.sdk.LPConversationData p0)
	{
		n_onConversationResolved (p0);
	}

	private native void n_onConversationResolved (com.liveperson.api.sdk.LPConversationData p0);


	public void onConversationStarted (com.liveperson.api.sdk.LPConversationData p0)
	{
		n_onConversationStarted (p0);
	}

	private native void n_onConversationStarted (com.liveperson.api.sdk.LPConversationData p0);


	public void onCsatDismissed ()
	{
		n_onCsatDismissed ();
	}

	private native void n_onCsatDismissed ();


	public void onCsatLaunched ()
	{
		n_onCsatLaunched ();
	}

	private native void n_onCsatLaunched ();


	public void onCsatSkipped ()
	{
		n_onCsatSkipped ();
	}

	private native void n_onCsatSkipped ();


	public void onCsatSubmitted (java.lang.String p0)
	{
		n_onCsatSubmitted (p0);
	}

	private native void n_onCsatSubmitted (java.lang.String p0);


	public void onError (com.liveperson.messaging.TaskType p0, java.lang.String p1)
	{
		n_onError (p0, p1);
	}

	private native void n_onError (com.liveperson.messaging.TaskType p0, java.lang.String p1);


	public void onOfflineHoursChanges (boolean p0)
	{
		n_onOfflineHoursChanges (p0);
	}

	private native void n_onOfflineHoursChanges (boolean p0);


	public void onStructuredContentLinkClicked (java.lang.String p0)
	{
		n_onStructuredContentLinkClicked (p0);
	}

	private native void n_onStructuredContentLinkClicked (java.lang.String p0);


	public void onTokenExpired ()
	{
		n_onTokenExpired ();
	}

	private native void n_onTokenExpired ();


	public void onUnauthenticatedUserExpired ()
	{
		n_onUnauthenticatedUserExpired ();
	}

	private native void n_onUnauthenticatedUserExpired ();


	public void onUserActionOnPreventedPermission (com.liveperson.api.sdk.PermissionType p0)
	{
		n_onUserActionOnPreventedPermission (p0);
	}

	private native void n_onUserActionOnPreventedPermission (com.liveperson.api.sdk.PermissionType p0);


	public void onUserDeniedPermission (com.liveperson.api.sdk.PermissionType p0, boolean p1)
	{
		n_onUserDeniedPermission (p0, p1);
	}

	private native void n_onUserDeniedPermission (com.liveperson.api.sdk.PermissionType p0, boolean p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
