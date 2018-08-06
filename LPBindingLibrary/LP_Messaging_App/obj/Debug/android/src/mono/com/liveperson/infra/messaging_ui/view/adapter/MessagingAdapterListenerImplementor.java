package mono.com.liveperson.infra.messaging_ui.view.adapter;


public class MessagingAdapterListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.messaging_ui.view.adapter.MessagingAdapterListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFileClicked:(Lcom/liveperson/messaging/background/filesharing/FileSharingType;Ljava/lang/String;Ljava/lang/String;JJ)V:GetOnFileClicked_Lcom_liveperson_messaging_background_filesharing_FileSharingType_Ljava_lang_String_Ljava_lang_String_JJHandler:Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MessagingAdapterListenerImplementor.class, __md_methods);
	}


	public MessagingAdapterListenerImplementor ()
	{
		super ();
		if (getClass () == MessagingAdapterListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Messaging_ui.View.Adapter.IMessagingAdapterListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFileClicked (com.liveperson.messaging.background.filesharing.FileSharingType p0, java.lang.String p1, java.lang.String p2, long p3, long p4)
	{
		n_onFileClicked (p0, p1, p2, p3, p4);
	}

	private native void n_onFileClicked (com.liveperson.messaging.background.filesharing.FileSharingType p0, java.lang.String p1, java.lang.String p2, long p3, long p4);

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
