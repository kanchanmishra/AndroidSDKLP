package mono.com.liveperson.infra.ui.view.ui;


public class TouchImageView_OnTouchImageViewListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.ui.view.ui.TouchImageView.OnTouchImageViewListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMove:()V:GetOnMoveHandler:Com.Liveperson.Infra.UI.View.UI.touchImageView/IOnTouchImageViewListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.UI.View.UI.touchImageView+IOnTouchImageViewListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TouchImageView_OnTouchImageViewListenerImplementor.class, __md_methods);
	}


	public TouchImageView_OnTouchImageViewListenerImplementor ()
	{
		super ();
		if (getClass () == TouchImageView_OnTouchImageViewListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.UI.View.UI.touchImageView+IOnTouchImageViewListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMove ()
	{
		n_onMove ();
	}

	private native void n_onMove ();

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
