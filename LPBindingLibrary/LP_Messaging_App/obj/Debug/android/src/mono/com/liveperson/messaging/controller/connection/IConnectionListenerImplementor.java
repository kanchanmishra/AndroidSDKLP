package mono.com.liveperson.messaging.controller.connection;


public class IConnectionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.messaging.controller.connection.IConnectionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_notifyConnected:()V:GetNotifyConnectedHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Android_aar_Binding\n" +
			"n_notifyDisconnected:()V:GetNotifyDisconnectedHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Android_aar_Binding\n" +
			"n_notifyError:(Lcom/liveperson/messaging/TaskType;Ljava/lang/String;)V:GetNotifyError_Lcom_liveperson_messaging_TaskType_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Android_aar_Binding\n" +
			"n_notifyStartConnecting:()V:GetNotifyStartConnectingHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Android_aar_Binding\n" +
			"n_notifyStartDisconnecting:()V:GetNotifyStartDisconnectingHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Android_aar_Binding\n" +
			"n_notifyTokenExpired:()V:GetNotifyTokenExpiredHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Android_aar_Binding\n" +
			"n_notifyUserExpired:()V:GetNotifyUserExpiredHandler:Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", IConnectionListenerImplementor.class, __md_methods);
	}


	public IConnectionListenerImplementor ()
	{
		super ();
		if (getClass () == IConnectionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Messaging.Controller.Connection.IConnectionListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void notifyConnected ()
	{
		n_notifyConnected ();
	}

	private native void n_notifyConnected ();


	public void notifyDisconnected ()
	{
		n_notifyDisconnected ();
	}

	private native void n_notifyDisconnected ();


	public void notifyError (com.liveperson.messaging.TaskType p0, java.lang.String p1)
	{
		n_notifyError (p0, p1);
	}

	private native void n_notifyError (com.liveperson.messaging.TaskType p0, java.lang.String p1);


	public void notifyStartConnecting ()
	{
		n_notifyStartConnecting ();
	}

	private native void n_notifyStartConnecting ();


	public void notifyStartDisconnecting ()
	{
		n_notifyStartDisconnecting ();
	}

	private native void n_notifyStartDisconnecting ();


	public void notifyTokenExpired ()
	{
		n_notifyTokenExpired ();
	}

	private native void n_notifyTokenExpired ();


	public void notifyUserExpired ()
	{
		n_notifyUserExpired ();
	}

	private native void n_notifyUserExpired ();

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
