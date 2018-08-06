package mono.com.liveperson.infra.ui.view.uicomponents;


public class ICloseMenuListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.ui.view.uicomponents.ICloseMenuListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseMenu:()V:GetOnCloseMenuHandler:Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ICloseMenuListenerImplementor.class, __md_methods);
	}


	public ICloseMenuListenerImplementor ()
	{
		super ();
		if (getClass () == ICloseMenuListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.UI.View.Uicomponents.ICloseMenuListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCloseMenu ()
	{
		n_onCloseMenu ();
	}

	private native void n_onCloseMenu ();

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
