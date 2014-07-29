package mono.com.google.android.gms.games.achievement;


public class OnAchievementsLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.achievement.OnAchievementsLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAchievementsLoaded:(ILcom/google/android/gms/games/achievement/AchievementBuffer;)V:GetOnAchievementsLoaded_ILcom_google_android_gms_games_achievement_AchievementBuffer_Handler:Android.Gms.Games.Achievement.IOnAchievementsLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.Achievement.IOnAchievementsLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnAchievementsLoadedListenerImplementor.class, __md_methods);
	}


	public OnAchievementsLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnAchievementsLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.Achievement.IOnAchievementsLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAchievementsLoaded (int p0, com.google.android.gms.games.achievement.AchievementBuffer p1)
	{
		n_onAchievementsLoaded (p0, p1);
	}

	private native void n_onAchievementsLoaded (int p0, com.google.android.gms.games.achievement.AchievementBuffer p1);

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
