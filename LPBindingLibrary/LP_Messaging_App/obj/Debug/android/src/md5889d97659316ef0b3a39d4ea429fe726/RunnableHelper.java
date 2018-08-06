package md5889d97659316ef0b3a39d4ea429fe726;


public class RunnableHelper
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		java.lang.Runnable
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_run:()V:GetRunHandler:Java.Lang.IRunnableInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("LP_Messaging_App.RunnableHelper, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RunnableHelper.class, __md_methods);
	}


	public RunnableHelper ()
	{
		super ();
		if (getClass () == RunnableHelper.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.RunnableHelper, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public RunnableHelper (java.lang.String p0, java.lang.String p1)
	{
		super ();
		if (getClass () == RunnableHelper.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.RunnableHelper, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void run ()
	{
		n_run ();
	}

	private native void n_run ();

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
