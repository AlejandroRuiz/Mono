package mono.com.google.android.gms.location;


public class LocationClient_OnRemoveGeofencesResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.location.LocationClient.OnRemoveGeofencesResultListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onRemoveGeofencesByPendingIntentResult:(ILandroid/app/PendingIntent;)V:GetOnRemoveGeofencesByPendingIntentResult_ILandroid_app_PendingIntent_Handler:Android.Gms.Location.LocationClient/IOnRemoveGeofencesResultListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onRemoveGeofencesByRequestIdsResult:(I[Ljava/lang/String;)V:GetOnRemoveGeofencesByRequestIdsResult_IarrayLjava_lang_String_Handler:Android.Gms.Location.LocationClient/IOnRemoveGeofencesResultListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Location.LocationClient/IOnRemoveGeofencesResultListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LocationClient_OnRemoveGeofencesResultListenerImplementor.class, __md_methods);
	}


	public LocationClient_OnRemoveGeofencesResultListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == LocationClient_OnRemoveGeofencesResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Location.LocationClient/IOnRemoveGeofencesResultListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onRemoveGeofencesByPendingIntentResult (int p0, android.app.PendingIntent p1)
	{
		n_onRemoveGeofencesByPendingIntentResult (p0, p1);
	}

	private native void n_onRemoveGeofencesByPendingIntentResult (int p0, android.app.PendingIntent p1);


	public void onRemoveGeofencesByRequestIdsResult (int p0, java.lang.String[] p1)
	{
		n_onRemoveGeofencesByRequestIdsResult (p0, p1);
	}

	private native void n_onRemoveGeofencesByRequestIdsResult (int p0, java.lang.String[] p1);

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
