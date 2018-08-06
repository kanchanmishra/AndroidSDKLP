package mono.com.liveperson.infra.messaging_ui.uicomponents.structuredcontent;


public class QRActionClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.messaging_ui.uicomponents.structuredcontent.QRActionClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:()V:GetOnClickHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", QRActionClickListenerImplementor.class, __md_methods);
	}


	public QRActionClickListenerImplementor ()
	{
		super ();
		if (getClass () == QRActionClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Messaging_ui.Uicomponents.Structuredcontent.IQRActionClickListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
