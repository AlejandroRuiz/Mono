package mono.com.google.android.gms.maps;


public class GoogleMap_OnMyLocationButtonClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.OnMyLocationButtonClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMyLocationButtonClick:()Z:GetOnMyLocationButtonClickHandler:Android.Gms.Maps.GoogleMap/IOnMyLocationButtonClickListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Maps.GoogleMap/IOnMyLocationButtonClickListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GoogleMap_OnMyLocationButtonClickListenerImplementor.class, __md_methods);
	}


	public boolean onMyLocationButtonClick ()
	{
		return n_onMyLocationButtonClick ();
	}

	private native boolean n_onMyLocationButtonClick ();

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
