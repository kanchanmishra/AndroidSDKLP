package mono.com.liveperson.infra.messaging_ui.uicomponents;


public class ChatMessageRecyclerView_OnLoadMoreListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.messaging_ui.uicomponents.ChatMessageRecyclerView.OnLoadMoreListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLoadMore:()V:GetOnLoadMoreHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView/IOnLoadMoreListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView+IOnLoadMoreListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChatMessageRecyclerView_OnLoadMoreListenerImplementor.class, __md_methods);
	}


	public ChatMessageRecyclerView_OnLoadMoreListenerImplementor ()
	{
		super ();
		if (getClass () == ChatMessageRecyclerView_OnLoadMoreListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Messaging_ui.Uicomponents.ChatMessageRecyclerView+IOnLoadMoreListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onLoadMore ()
	{
		n_onLoadMore ();
	}

	private native void n_onLoadMore ();

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
