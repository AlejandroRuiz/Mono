package mono.com.google.android.gms.games;


public class OnPlayersLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.OnPlayersLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPlayersLoaded:(ILcom/google/android/gms/games/PlayerBuffer;)V:GetOnPlayersLoaded_ILcom_google_android_gms_games_PlayerBuffer_Handler:Android.Gms.Games.IOnPlayersLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.IOnPlayersLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnPlayersLoadedListenerImplementor.class, __md_methods);
	}


	public OnPlayersLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnPlayersLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.IOnPlayersLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPlayersLoaded (int p0, com.google.android.gms.games.PlayerBuffer p1)
	{
		n_onPlayersLoaded (p0, p1);
	}

	private native void n_onPlayersLoaded (int p0, com.google.android.gms.games.PlayerBuffer p1);

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
