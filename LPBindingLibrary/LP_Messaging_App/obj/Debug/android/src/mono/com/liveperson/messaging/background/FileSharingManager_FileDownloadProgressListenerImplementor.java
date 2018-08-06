package mono.com.liveperson.messaging.background;


public class FileSharingManager_FileDownloadProgressListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.messaging.background.FileSharingManager.FileDownloadProgressListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDoneDownload:()V:GetOnDoneDownloadHandler:Com.Liveperson.Messaging.Background.FileSharingManager/IFileDownloadProgressListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onFailedDownload:(Ljava/lang/Throwable;)V:GetOnFailedDownload_Ljava_lang_Throwable_Handler:Com.Liveperson.Messaging.Background.FileSharingManager/IFileDownloadProgressListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Messaging.Background.FileSharingManager+IFileDownloadProgressListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FileSharingManager_FileDownloadProgressListenerImplementor.class, __md_methods);
	}


	public FileSharingManager_FileDownloadProgressListenerImplementor ()
	{
		super ();
		if (getClass () == FileSharingManager_FileDownloadProgressListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Messaging.Background.FileSharingManager+IFileDownloadProgressListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDoneDownload ()
	{
		n_onDoneDownload ();
	}

	private native void n_onDoneDownload ();


	public void onFailedDownload (java.lang.Throwable p0)
	{
		n_onFailedDownload (p0);
	}

	private native void n_onFailedDownload (java.lang.Throwable p0);

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
