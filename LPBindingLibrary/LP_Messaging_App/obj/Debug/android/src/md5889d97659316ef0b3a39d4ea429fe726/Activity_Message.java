package md5889d97659316ef0b3a39d4ea429fe726;


public class Activity_Message
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("LP_Messaging_App.Activity_Message, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Activity_Message.class, __md_methods);
	}


	public Activity_Message ()
	{
		super ();
		if (getClass () == Activity_Message.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.Activity_Message, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
