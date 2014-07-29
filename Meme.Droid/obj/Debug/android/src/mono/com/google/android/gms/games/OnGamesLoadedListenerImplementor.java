package mono.com.google.android.gms.games;


public class OnGamesLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.OnGamesLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onGamesLoaded:(ILcom/google/android/gms/games/GameBuffer;)V:GetOnGamesLoaded_ILcom_google_android_gms_games_GameBuffer_Handler:Android.Gms.Games.IOnGamesLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.IOnGamesLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnGamesLoadedListenerImplementor.class, __md_methods);
	}


	public OnGamesLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnGamesLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.IOnGamesLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onGamesLoaded (int p0, com.google.android.gms.games.GameBuffer p1)
	{
		n_onGamesLoaded (p0, p1);
	}

	private native void n_onGamesLoaded (int p0, com.google.android.gms.games.GameBuffer p1);

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
