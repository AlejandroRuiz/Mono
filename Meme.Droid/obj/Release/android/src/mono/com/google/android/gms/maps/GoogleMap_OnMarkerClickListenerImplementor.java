package mono.com.google.android.gms.maps;


public class GoogleMap_OnMarkerClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.OnMarkerClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMarkerClick:(Lcom/google/android/gms/maps/model/Marker;)Z:GetOnMarkerClick_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IOnMarkerClickListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Maps.GoogleMap/IOnMarkerClickListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GoogleMap_OnMarkerClickListenerImplementor.class, __md_methods);
	}


	public boolean onMarkerClick (com.google.android.gms.maps.model.Marker p0)
	{
		return n_onMarkerClick (p0);
	}

	private native boolean n_onMarkerClick (com.google.android.gms.maps.model.Marker p0);

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
