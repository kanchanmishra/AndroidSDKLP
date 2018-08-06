package mono.com.liveperson.infra.sdkstatemachine.shutdown;


public class ShutDownCompletionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.sdkstatemachine.shutdown.ShutDownCompletionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_shutDownCompleted:()V:GetShutDownCompletedHandler:Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListenerInvoker, LP_Android_aar_Binding\n" +
			"n_shutDownFailed:()V:GetShutDownFailedHandler:Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ShutDownCompletionListenerImplementor.class, __md_methods);
	}


	public ShutDownCompletionListenerImplementor ()
	{
		super ();
		if (getClass () == ShutDownCompletionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Sdkstatemachine.Shutdown.IShutDownCompletionListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void shutDownCompleted ()
	{
		n_shutDownCompleted ();
	}

	private native void n_shutDownCompleted ();


	public void shutDownFailed ()
	{
		n_shutDownFailed ();
	}

	private native void n_shutDownFailed ();

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
