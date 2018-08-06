package mono.com.liveperson.messaging.background;


public class FileSharingManager_FileUploadProgressListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.liveperson.messaging.background.FileSharingManager.FileUploadProgressListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDoneUpload:()V:GetOnDoneUploadHandler:Com.Liveperson.Messaging.Background.FileSharingManager/IFileUploadProgressListenerInvoker, LP_Android_aar_Binding\n" +
			"n_onFailedUpload:(Ljava/lang/Throwable;)V:GetOnFailedUpload_Ljava_lang_Throwable_Handler:Com.Liveperson.Messaging.Background.FileSharingManager/IFileUploadProgressListenerInvoker, LP_Android_aar_Binding\n" +
			"";
		mono.android.Runtime.register ("Com.Liveperson.Messaging.Background.FileSharingManager+IFileUploadProgressListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FileSharingManager_FileUploadProgressListenerImplementor.class, __md_methods);
	}


	public FileSharingManager_FileUploadProgressListenerImplementor ()
	{
		super ();
		if (getClass () == FileSharingManager_FileUploadProgressListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Liveperson.Messaging.Background.FileSharingManager+IFileUploadProgressListenerImplementor, LP_Android_aar_Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDoneUpload ()
	{
		n_onDoneUpload ();
	}

	private native void n_onDoneUpload ();


	public void onFailedUpload (java.lang.Throwable p0)
	{
		n_onFailedUpload (p0);
	}

	private native void n_onFailedUpload (java.lang.Throwable p0);

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
