package mono.com.liveperson.infra.database.transaction_helper;


public class SQLiteCommand_SQLiteCommandListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.database.transaction_helper.SQLiteCommand.SQLiteCommandListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInsertComplete:(J)V:GetOnInsertComplete_JHandler:Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand/ISQLiteCommandListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand+ISQLiteCommandListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SQLiteCommand_SQLiteCommandListenerImplementor.class, __md_methods);
	}


	public SQLiteCommand_SQLiteCommandListenerImplementor ()
	{
		super ();
		if (getClass () == SQLiteCommand_SQLiteCommandListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Database.Transaction_helper.SQLiteCommand+ISQLiteCommandListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onInsertComplete (long p0)
	{
		n_onInsertComplete (p0);
	}

	private native void n_onInsertComplete (long p0);

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
