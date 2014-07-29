package mono.com.google.android.gms.panorama;


public class PanoramaClient_OnPanoramaInfoLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.panorama.PanoramaClient.OnPanoramaInfoLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPanoramaInfoLoaded:(Lcom/google/android/gms/common/ConnectionResult;Landroid/content/Intent;)V:GetOnPanoramaInfoLoaded_Lcom_google_android_gms_common_ConnectionResult_Landroid_content_Intent_Handler:Android.Gms.Panorama.PanoramaClient/IOnPanoramaInfoLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Panorama.PanoramaClient/IOnPanoramaInfoLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PanoramaClient_OnPanoramaInfoLoadedListenerImplementor.class, __md_methods);
	}


	public PanoramaClient_OnPanoramaInfoLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PanoramaClient_OnPanoramaInfoLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Panorama.PanoramaClient/IOnPanoramaInfoLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPanoramaInfoLoaded (com.google.android.gms.common.ConnectionResult p0, android.content.Intent p1)
	{
		n_onPanoramaInfoLoaded (p0, p1);
	}

	private native void n_onPanoramaInfoLoaded (com.google.android.gms.common.ConnectionResult p0, android.content.Intent p1);

	java.util.ArrayList refList;
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
