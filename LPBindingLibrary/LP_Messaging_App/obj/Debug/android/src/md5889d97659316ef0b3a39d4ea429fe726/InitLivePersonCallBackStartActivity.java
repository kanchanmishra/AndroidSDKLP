package md5889d97659316ef0b3a39d4ea429fe726;


public class InitLivePersonCallBackStartActivity
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.callbacks.InitLivePersonCallBack
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInitFailed:(Ljava/lang/Exception;)V:GetOnInitFailed_Ljava_lang_Exception_Handler:Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBackInvoker, LP_Android_aar_Binding\n" +
			"n_onInitSucceed:()V:GetOnInitSucceedHandler:Com.Liveperson.Infra.Callbacks.IInitLivePersonCallBackInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("LP_Messaging_App.InitLivePersonCallBackStartActivity, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", InitLivePersonCallBackStartActivity.class, __md_methods);
	}


	public InitLivePersonCallBackStartActivity ()
	{
		super ();
		if (getClass () == InitLivePersonCallBackStartActivity.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.InitLivePersonCallBackStartActivity, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public InitLivePersonCallBackStartActivity (android.content.Context p0)
	{
		super ();
		if (getClass () == InitLivePersonCallBackStartActivity.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.InitLivePersonCallBackStartActivity, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void onInitFailed (java.lang.Exception p0)
	{
		n_onInitFailed (p0);
	}

	private native void n_onInitFailed (java.lang.Exception p0);


	public void onInitSucceed ()
	{
		n_onInitSucceed ();
	}

	private native void n_onInitSucceed ();

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
