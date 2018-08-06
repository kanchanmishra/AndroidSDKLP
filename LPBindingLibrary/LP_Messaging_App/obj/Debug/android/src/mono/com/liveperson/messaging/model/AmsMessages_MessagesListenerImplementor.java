package mono.com.liveperson.messaging.model;


public class AmsMessages_MessagesListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.messaging.model.AmsMessages.MessagesListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_initMessages:(Ljava/util/ArrayList;)V:GetInitMessages_Ljava_util_ArrayList_Handler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onExConversationHandled:(Z)V:GetOnExConversationHandled_ZHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onHistoryFetched:()V:GetOnHistoryFetchedHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onHistoryFetchedFailed:()V:GetOnHistoryFetchedFailedHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onNewMessage:(Lcom/liveperson/messaging/model/FullMessageRow;)V:GetOnNewMessage_Lcom_liveperson_messaging_model_FullMessageRow_Handler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onQueryMessagesResult:(JJ)V:GetOnQueryMessagesResult_JJHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onUpdateMessage:(Lcom/liveperson/messaging/model/FullMessageRow;)V:GetOnUpdateMessage_Lcom_liveperson_messaging_model_FullMessageRow_Handler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onUpdateMessages:(JJ)V:GetOnUpdateMessages_JJHandler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"n_removeAll:(Ljava/lang/String;)V:GetRemoveAll_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Model.AmsMessages/IMessagesListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Messaging.Model.AmsMessages+IMessagesListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AmsMessages_MessagesListenerImplementor.class, __md_methods);
	}


	public AmsMessages_MessagesListenerImplementor ()
	{
		super ();
		if (getClass () == AmsMessages_MessagesListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Messaging.Model.AmsMessages+IMessagesListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void initMessages (java.util.ArrayList p0)
	{
		n_initMessages (p0);
	}

	private native void n_initMessages (java.util.ArrayList p0);


	public void onExConversationHandled (boolean p0)
	{
		n_onExConversationHandled (p0);
	}

	private native void n_onExConversationHandled (boolean p0);


	public void onHistoryFetched ()
	{
		n_onHistoryFetched ();
	}

	private native void n_onHistoryFetched ();


	public void onHistoryFetchedFailed ()
	{
		n_onHistoryFetchedFailed ();
	}

	private native void n_onHistoryFetchedFailed ();


	public void onNewMessage (com.liveperson.messaging.model.FullMessageRow p0)
	{
		n_onNewMessage (p0);
	}

	private native void n_onNewMessage (com.liveperson.messaging.model.FullMessageRow p0);


	public void onQueryMessagesResult (long p0, long p1)
	{
		n_onQueryMessagesResult (p0, p1);
	}

	private native void n_onQueryMessagesResult (long p0, long p1);


	public void onUpdateMessage (com.liveperson.messaging.model.FullMessageRow p0)
	{
		n_onUpdateMessage (p0);
	}

	private native void n_onUpdateMessage (com.liveperson.messaging.model.FullMessageRow p0);


	public void onUpdateMessages (long p0, long p1)
	{
		n_onUpdateMessages (p0, p1);
	}

	private native void n_onUpdateMessages (long p0, long p1);


	public void removeAll (java.lang.String p0)
	{
		n_removeAll (p0);
	}

	private native void n_removeAll (java.lang.String p0);

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
