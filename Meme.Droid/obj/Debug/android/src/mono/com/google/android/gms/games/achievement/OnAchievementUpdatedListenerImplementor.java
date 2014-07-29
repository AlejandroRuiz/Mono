package mono.com.google.android.gms.games.achievement;


public class OnAchievementUpdatedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.achievement.OnAchievementUpdatedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAchievementUpdated:(ILjava/lang/String;)V:GetOnAchievementUpdated_ILjava_lang_String_Handler:Android.Gms.Games.Achievement.IOnAchievementUpdatedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.Achievement.IOnAchievementUpdatedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnAchievementUpdatedListenerImplementor.class, __md_methods);
	}


	public OnAchievementUpdatedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnAchievementUpdatedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.Achievement.IOnAchievementUpdatedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAchievementUpdated (int p0, java.lang.String p1)
	{
		n_onAchievementUpdated (p0, p1);
	}

	private native void n_onAchievementUpdated (int p0, java.lang.String p1);

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
