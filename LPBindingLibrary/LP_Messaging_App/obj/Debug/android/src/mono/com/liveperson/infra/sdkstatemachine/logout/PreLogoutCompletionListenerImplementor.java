package mono.com.liveperson.infra.sdkstatemachine.logout;


public class PreLogoutCompletionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.sdkstatemachine.logout.PreLogoutCompletionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_preLogoutCompleted:()V:GetPreLogoutCompletedHandler:Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListenerInvoker, LP_Android_aar_Binding\n" +
			"n_preLogoutFailed:(Ljava/lang/Exception;)V:GetPreLogoutFailed_Ljava_lang_Exception_Handler:Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PreLogoutCompletionListenerImplementor.class, __md_methods);
	}


	public PreLogoutCompletionListenerImplementor ()
	{
		super ();
		if (getClass () == PreLogoutCompletionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Sdkstatemachine.Logout.IPreLogoutCompletionListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void preLogoutCompleted ()
	{
		n_preLogoutCompleted ();
	}

	private native void n_preLogoutCompleted ();


	public void preLogoutFailed (java.lang.Exception p0)
	{
		n_preLogoutFailed (p0);
	}

	private native void n_preLogoutFailed (java.lang.Exception p0);

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
