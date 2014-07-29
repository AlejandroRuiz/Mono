package mono.com.google.android.gms.common;


public class GooglePlayServicesClient_OnConnectionFailedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.common.GooglePlayServicesClient.OnConnectionFailedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onConnectionFailed:(Lcom/google/android/gms/common/ConnectionResult;)V:GetOnConnectionFailed_Lcom_google_android_gms_common_ConnectionResult_Handler:Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GooglePlayServicesClient_OnConnectionFailedListenerImplementor.class, __md_methods);
	}


	public GooglePlayServicesClient_OnConnectionFailedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GooglePlayServicesClient_OnConnectionFailedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Common.IGooglePlayServicesClientOnConnectionFailedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onConnectionFailed (com.google.android.gms.common.ConnectionResult p0)
	{
		n_onConnectionFailed (p0);
	}

	private native void n_onConnectionFailed (com.google.android.gms.common.ConnectionResult p0);

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
