package mono.com.liveperson.infra.network.socket.state;


public class SocketStateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.network.socket.state.SocketStateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDisconnected:(Ljava/lang/String;I)V:GetOnDisconnected_Ljava_lang_String_IHandler:Com.Liveperson.Infra.Network.Socket.State.ISocketStateListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onStateChanged:(Lcom/liveperson/infra/network/socket/SocketState;)V:GetOnStateChanged_Lcom_liveperson_infra_network_socket_SocketState_Handler:Com.Liveperson.Infra.Network.Socket.State.ISocketStateListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Network.Socket.State.ISocketStateListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SocketStateListenerImplementor.class, __md_methods);
	}


	public SocketStateListenerImplementor ()
	{
		super ();
		if (getClass () == SocketStateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Network.Socket.State.ISocketStateListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDisconnected (java.lang.String p0, int p1)
	{
		n_onDisconnected (p0, p1);
	}

	private native void n_onDisconnected (java.lang.String p0, int p1);


	public void onStateChanged (com.liveperson.infra.network.socket.SocketState p0)
	{
		n_onStateChanged (p0);
	}

	private native void n_onStateChanged (com.liveperson.infra.network.socket.SocketState p0);

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
