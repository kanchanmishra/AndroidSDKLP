package mono.com.liveperson.messaging.commands;


public class SendFileCommand_SendFileCommandListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.messaging.commands.SendFileCommand.SendFileCommandListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFileAddedToDB:(JJ)V:GetOnFileAddedToDB_JJHandler:Com.Liveperson.Messaging.Commands.SendFileCommand/ISendFileCommandListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onMessageUpdatedInDB:()V:GetOnMessageUpdatedInDBHandler:Com.Liveperson.Messaging.Commands.SendFileCommand/ISendFileCommandListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Messaging.Commands.SendFileCommand+ISendFileCommandListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SendFileCommand_SendFileCommandListenerImplementor.class, __md_methods);
	}


	public SendFileCommand_SendFileCommandListenerImplementor ()
	{
		super ();
		if (getClass () == SendFileCommand_SendFileCommandListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Messaging.Commands.SendFileCommand+ISendFileCommandListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFileAddedToDB (long p0, long p1)
	{
		n_onFileAddedToDB (p0, p1);
	}

	private native void n_onFileAddedToDB (long p0, long p1);


	public void onMessageUpdatedInDB ()
	{
		n_onMessageUpdatedInDB ();
	}

	private native void n_onMessageUpdatedInDB ();

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
