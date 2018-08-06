package mono.com.liveperson.messaging.network.http;


public class MessageTimeoutListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.messaging.network.http.MessageTimeoutListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMessageTimeout:(Ljava/lang/String;)V:GetOnMessageTimeout_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onPublishMessageTimeout:(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V:GetOnPublishMessageTimeout_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MessageTimeoutListenerImplementor.class, __md_methods);
	}


	public MessageTimeoutListenerImplementor ()
	{
		super ();
		if (getClass () == MessageTimeoutListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Messaging.Network.Http.IMessageTimeoutListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMessageTimeout (java.lang.String p0)
	{
		n_onMessageTimeout (p0);
	}

	private native void n_onMessageTimeout (java.lang.String p0);


	public void onPublishMessageTimeout (java.lang.String p0, java.lang.String p1, java.lang.String p2)
	{
		n_onPublishMessageTimeout (p0, p1, p2);
	}

	private native void n_onPublishMessageTimeout (java.lang.String p0, java.lang.String p1, java.lang.String p2);

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
