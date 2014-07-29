package mono.com.google.android.gms.games;


public class OnSignOutCompleteListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.OnSignOutCompleteListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onSignOutComplete:()V:GetOnSignOutCompleteHandler:Android.Gms.Games.IOnSignOutCompleteListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.IOnSignOutCompleteListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnSignOutCompleteListenerImplementor.class, __md_methods);
	}


	public OnSignOutCompleteListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnSignOutCompleteListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.IOnSignOutCompleteListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSignOutComplete ()
	{
		n_onSignOutComplete ();
	}

	private native void n_onSignOutComplete ();

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
