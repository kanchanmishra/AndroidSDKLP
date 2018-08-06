package mono.com.liveperson.infra.messaging_ui.uicomponents.list;


public class ChatMessageBgFgListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.messaging_ui.uicomponents.list.ChatMessageBgFgListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBackground:()V:GetOnBackgroundHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onForeground:()V:GetOnForegroundHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChatMessageBgFgListenerImplementor.class, __md_methods);
	}


	public ChatMessageBgFgListenerImplementor ()
	{
		super ();
		if (getClass () == ChatMessageBgFgListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Messaging_ui.Uicomponents.List.IChatMessageBgFgListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onBackground ()
	{
		n_onBackground ();
	}

	private native void n_onBackground ();


	public void onForeground ()
	{
		n_onForeground ();
	}

	private native void n_onForeground ();

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
