package mono.com.liveperson.infra.messaging_ui.uicomponents;


public class AttachmentMenu_AttachmentMenuListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.messaging_ui.uicomponents.AttachmentMenu.AttachmentMenuListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCameraButtonPressed:()V:GetOnCameraButtonPressedHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu/IAttachmentMenuListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onGalleryButtonPressed:()V:GetOnGalleryButtonPressedHandler:Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu/IAttachmentMenuListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu+IAttachmentMenuListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AttachmentMenu_AttachmentMenuListenerImplementor.class, __md_methods);
	}


	public AttachmentMenu_AttachmentMenuListenerImplementor ()
	{
		super ();
		if (getClass () == AttachmentMenu_AttachmentMenuListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Messaging_ui.Uicomponents.AttachmentMenu+IAttachmentMenuListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCameraButtonPressed ()
	{
		n_onCameraButtonPressed ();
	}

	private native void n_onCameraButtonPressed ();


	public void onGalleryButtonPressed ()
	{
		n_onGalleryButtonPressed ();
	}

	private native void n_onGalleryButtonPressed ();

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
