package mono.com.liveperson.messaging.structuredcontent.model.actions;


public class OnActionClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.messaging.structuredcontent.model.actions.OnActionClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:()V:GetOnClickHandler:Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnActionClickListenerImplementor.class, __md_methods);
	}


	public OnActionClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnActionClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Messaging.Structuredcontent.Model.Actions.IOnActionClickListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onClick ()
	{
		n_onClick ();
	}

	private native void n_onClick ();

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
