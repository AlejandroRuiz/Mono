package mono.com.google.android.gms.location;


public class LocationClient_OnAddGeofencesResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.location.LocationClient.OnAddGeofencesResultListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAddGeofencesResult:(I[Ljava/lang/String;)V:GetOnAddGeofencesResult_IarrayLjava_lang_String_Handler:Android.Gms.Location.LocationClient/IOnAddGeofencesResultListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Location.LocationClient/IOnAddGeofencesResultListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LocationClient_OnAddGeofencesResultListenerImplementor.class, __md_methods);
	}


	public LocationClient_OnAddGeofencesResultListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LocationClient_OnAddGeofencesResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Location.LocationClient/IOnAddGeofencesResultListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAddGeofencesResult (int p0, java.lang.String[] p1)
	{
		n_onAddGeofencesResult (p0, p1);
	}

	private native void n_onAddGeofencesResult (int p0, java.lang.String[] p1);

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
