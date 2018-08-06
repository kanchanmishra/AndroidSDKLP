package mono.com.liveperson.infra.sdkstatemachine.logout;


public class LogoutCompletionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.sdkstatemachine.logout.LogoutCompletionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_logoutCompleted:()V:GetLogoutCompletedHandler:Com.Liveperson.Infra.Sdkstatemachine.Logout.ILogoutCompletionListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Sdkstatemachine.Logout.ILogoutCompletionListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LogoutCompletionListenerImplementor.class, __md_methods);
	}


	public LogoutCompletionListenerImplementor ()
	{
		super ();
		if (getClass () == LogoutCompletionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Sdkstatemachine.Logout.ILogoutCompletionListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void logoutCompleted ()
	{
		n_logoutCompleted ();
	}

	private native void n_logoutCompleted ();

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
