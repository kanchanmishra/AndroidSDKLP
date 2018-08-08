package md5889d97659316ef0b3a39d4ea429fe726;


public class LPReceiver
	extends android.content.BroadcastReceiver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceive:(Landroid/content/Context;Landroid/content/Intent;)V:GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("LP_Messaging_App.LPReceiver, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LPReceiver.class, __md_methods);
	}


	public LPReceiver ()
	{
		super ();
		if (getClass () == LPReceiver.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.LPReceiver, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public LPReceiver (android.content.Context p0, boolean p1, android.content.Intent p2)
	{
		super ();
		if (getClass () == LPReceiver.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.LPReceiver, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:Android.Content.Intent, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onReceive (android.content.Context p0, android.content.Intent p1)
	{
		n_onReceive (p0, p1);
	}

	private native void n_onReceive (android.content.Context p0, android.content.Intent p1);

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
