package mono.com.google.android.gms.appstate;


public class OnStateListLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.appstate.OnStateListLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onStateListLoaded:(ILcom/google/android/gms/appstate/AppStateBuffer;)V:GetOnStateListLoaded_ILcom_google_android_gms_appstate_AppStateBuffer_Handler:Android.Gms.AppStates.IOnStateListLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.AppStates.IOnStateListLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnStateListLoadedListenerImplementor.class, __md_methods);
	}


	public OnStateListLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnStateListLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.AppStates.IOnStateListLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onStateListLoaded (int p0, com.google.android.gms.appstate.AppStateBuffer p1)
	{
		n_onStateListLoaded (p0, p1);
	}

	private native void n_onStateListLoaded (int p0, com.google.android.gms.appstate.AppStateBuffer p1);

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
