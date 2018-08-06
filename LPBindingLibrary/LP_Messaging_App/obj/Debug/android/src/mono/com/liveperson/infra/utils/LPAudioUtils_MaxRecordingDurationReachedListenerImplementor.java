package mono.com.liveperson.infra.utils;


public class LPAudioUtils_MaxRecordingDurationReachedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.infra.utils.LPAudioUtils.MaxRecordingDurationReachedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMaxRecordingDurationReached:(Ljava/lang/String;)V:GetOnMaxRecordingDurationReached_Ljava_lang_String_Handler:Com.Liveperson.Infra.Utils.LPAudioUtils/IMaxRecordingDurationReachedListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Infra.Utils.LPAudioUtils+IMaxRecordingDurationReachedListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LPAudioUtils_MaxRecordingDurationReachedListenerImplementor.class, __md_methods);
	}


	public LPAudioUtils_MaxRecordingDurationReachedListenerImplementor ()
	{
		super ();
		if (getClass () == LPAudioUtils_MaxRecordingDurationReachedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Infra.Utils.LPAudioUtils+IMaxRecordingDurationReachedListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMaxRecordingDurationReached (java.lang.String p0)
	{
		n_onMaxRecordingDurationReached (p0);
	}

	private native void n_onMaxRecordingDurationReached (java.lang.String p0);

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
