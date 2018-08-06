package mono.com.liveperson.messaging.background;


public class BackgroundActionsService_ServiceActionCallbackListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.messaging.background.BackgroundActionsService.ServiceActionCallbackListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFail:(Ljava/lang/String;)V:GetOnFail_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Background.BackgroundActionsService/IServiceActionCallbackListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onSuccess:(Ljava/lang/String;)V:GetOnSuccess_Ljava_lang_String_Handler:Com.Liveperson.Messaging.Background.BackgroundActionsService/IServiceActionCallbackListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Messaging.Background.BackgroundActionsService+IServiceActionCallbackListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BackgroundActionsService_ServiceActionCallbackListenerImplementor.class, __md_methods);
	}


	public BackgroundActionsService_ServiceActionCallbackListenerImplementor ()
	{
		super ();
		if (getClass () == BackgroundActionsService_ServiceActionCallbackListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Messaging.Background.BackgroundActionsService+IServiceActionCallbackListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFail (java.lang.String p0)
	{
		n_onFail (p0);
	}

	private native void n_onFail (java.lang.String p0);


	public void onSuccess (java.lang.String p0)
	{
		n_onSuccess (p0);
	}

	private native void n_onSuccess (java.lang.String p0);

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
