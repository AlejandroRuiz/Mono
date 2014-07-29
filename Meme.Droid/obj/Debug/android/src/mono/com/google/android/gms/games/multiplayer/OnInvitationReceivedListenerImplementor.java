package mono.com.google.android.gms.games.multiplayer;


public class OnInvitationReceivedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.multiplayer.OnInvitationReceivedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onInvitationReceived:(Lcom/google/android/gms/games/multiplayer/Invitation;)V:GetOnInvitationReceived_Lcom_google_android_gms_games_multiplayer_Invitation_Handler:Android.Gms.Games.MultiPlayer.IOnInvitationReceivedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.MultiPlayer.IOnInvitationReceivedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnInvitationReceivedListenerImplementor.class, __md_methods);
	}


	public OnInvitationReceivedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnInvitationReceivedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.MultiPlayer.IOnInvitationReceivedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onInvitationReceived (com.google.android.gms.games.multiplayer.Invitation p0)
	{
		n_onInvitationReceived (p0);
	}

	private native void n_onInvitationReceived (com.google.android.gms.games.multiplayer.Invitation p0);

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
