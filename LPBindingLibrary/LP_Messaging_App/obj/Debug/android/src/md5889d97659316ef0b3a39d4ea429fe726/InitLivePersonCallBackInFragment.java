package md5889d97659316ef0b3a39d4ea429fe726;


public class InitLivePersonCallBackInFragment
	extends android.support.v7.app.AppCompatActivity
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
		mono.android.Runtime.register ("LP_Messaging_App.InitLivePersonCallBackInFragment, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", InitLivePersonCallBackInFragment.class, __md_methods);
	}


	public InitLivePersonCallBackInFragment ()
	{
		super ();
		if (getClass () == InitLivePersonCallBackInFragment.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.InitLivePersonCallBackInFragment, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public InitLivePersonCallBackInFragment (android.content.Context p0, java.lang.String p1, java.lang.String p2, java.lang.String p3, java.lang.String p4, java.lang.String p5)
	{
		super ();
		if (getClass () == InitLivePersonCallBackInFragment.class)
			mono.android.TypeManager.Activate ("LP_Messaging_App.InitLivePersonCallBackInFragment, LP_Messaging_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3, p4, p5 });
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
