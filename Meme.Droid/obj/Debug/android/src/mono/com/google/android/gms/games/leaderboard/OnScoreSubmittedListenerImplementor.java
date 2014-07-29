package mono.com.google.android.gms.games.leaderboard;


public class OnScoreSubmittedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.leaderboard.OnScoreSubmittedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onScoreSubmitted:(ILcom/google/android/gms/games/leaderboard/SubmitScoreResult;)V:GetOnScoreSubmitted_ILcom_google_android_gms_games_leaderboard_SubmitScoreResult_Handler:Android.Gms.Games.LeaderBoard.IOnScoreSubmittedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.LeaderBoard.IOnScoreSubmittedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnScoreSubmittedListenerImplementor.class, __md_methods);
	}


	public OnScoreSubmittedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnScoreSubmittedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.LeaderBoard.IOnScoreSubmittedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onScoreSubmitted (int p0, com.google.android.gms.games.leaderboard.SubmitScoreResult p1)
	{
		n_onScoreSubmitted (p0, p1);
	}

	private native void n_onScoreSubmitted (int p0, com.google.android.gms.games.leaderboard.SubmitScoreResult p1);

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
