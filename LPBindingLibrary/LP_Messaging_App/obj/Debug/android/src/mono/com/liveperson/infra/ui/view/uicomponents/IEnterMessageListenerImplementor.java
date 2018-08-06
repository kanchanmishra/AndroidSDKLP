package mono.com.liveperson.infra.ui.view.uicomponents;


public class IEnterMessageListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.ui.view.uicomponents.IEnterMessageListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMessageSent:()V:GetOnMessageSentHandler:Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onVoiceRecordingPermissionRequired:(Lcom/liveperson/infra/IPermissionCallback;)V:GetOnVoiceRecordingPermissionRequired_Lcom_liveperson_infra_IPermissionCallback_Handler:Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", IEnterMessageListenerImplementor.class, __md_methods);
	}


	public IEnterMessageListenerImplementor ()
	{
		super ();
		if (getClass () == IEnterMessageListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.UI.View.Uicomponents.IEnterMessageListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMessageSent ()
	{
		n_onMessageSent ();
	}

	private native void n_onMessageSent ();


	public void onVoiceRecordingPermissionRequired (com.liveperson.infra.IPermissionCallback p0)
	{
		n_onVoiceRecordingPermissionRequired (p0);
	}

	private native void n_onVoiceRecordingPermissionRequired (com.liveperson.infra.IPermissionCallback p0);

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
