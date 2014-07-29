package mono.com.google.android.gms.games.multiplayer.realtime;


public class RoomStatusUpdateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.multiplayer.realtime.RoomStatusUpdateListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onConnectedToRoom:(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V:GetOnConnectedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onDisconnectedFromRoom:(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V:GetOnDisconnectedFromRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onP2PConnected:(Ljava/lang/String;)V:GetOnP2PConnected_Ljava_lang_String_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onP2PDisconnected:(Ljava/lang/String;)V:GetOnP2PDisconnected_Ljava_lang_String_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onPeerDeclined:(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V:GetOnPeerDeclined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onPeerInvitedToRoom:(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V:GetOnPeerInvitedToRoom_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onPeerJoined:(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V:GetOnPeerJoined_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onPeerLeft:(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V:GetOnPeerLeft_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onPeersConnected:(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V:GetOnPeersConnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onPeersDisconnected:(Lcom/google/android/gms/games/multiplayer/realtime/Room;Ljava/util/List;)V:GetOnPeersDisconnected_Lcom_google_android_gms_games_multiplayer_realtime_Room_Ljava_util_List_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onRoomAutoMatching:(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V:GetOnRoomAutoMatching_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onRoomConnecting:(Lcom/google/android/gms/games/multiplayer/realtime/Room;)V:GetOnRoomConnecting_Lcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RoomStatusUpdateListenerImplementor.class, __md_methods);
	}


	public RoomStatusUpdateListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RoomStatusUpdateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.Multiplayer.Realtime.IRoomStatusUpdateListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onConnectedToRoom (com.google.android.gms.games.multiplayer.realtime.Room p0)
	{
		n_onConnectedToRoom (p0);
	}

	private native void n_onConnectedToRoom (com.google.android.gms.games.multiplayer.realtime.Room p0);


	public void onDisconnectedFromRoom (com.google.android.gms.games.multiplayer.realtime.Room p0)
	{
		n_onDisconnectedFromRoom (p0);
	}

	private native void n_onDisconnectedFromRoom (com.google.android.gms.games.multiplayer.realtime.Room p0);


	public void onP2PConnected (java.lang.String p0)
	{
		n_onP2PConnected (p0);
	}

	private native void n_onP2PConnected (java.lang.String p0);


	public void onP2PDisconnected (java.lang.String p0)
	{
		n_onP2PDisconnected (p0);
	}

	private native void n_onP2PDisconnected (java.lang.String p0);


	public void onPeerDeclined (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1)
	{
		n_onPeerDeclined (p0, p1);
	}

	private native void n_onPeerDeclined (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1);


	public void onPeerInvitedToRoom (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1)
	{
		n_onPeerInvitedToRoom (p0, p1);
	}

	private native void n_onPeerInvitedToRoom (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1);


	public void onPeerJoined (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1)
	{
		n_onPeerJoined (p0, p1);
	}

	private native void n_onPeerJoined (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1);


	public void onPeerLeft (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1)
	{
		n_onPeerLeft (p0, p1);
	}

	private native void n_onPeerLeft (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1);


	public void onPeersConnected (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1)
	{
		n_onPeersConnected (p0, p1);
	}

	private native void n_onPeersConnected (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1);


	public void onPeersDisconnected (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1)
	{
		n_onPeersDisconnected (p0, p1);
	}

	private native void n_onPeersDisconnected (com.google.android.gms.games.multiplayer.realtime.Room p0, java.util.List p1);


	public void onRoomAutoMatching (com.google.android.gms.games.multiplayer.realtime.Room p0)
	{
		n_onRoomAutoMatching (p0);
	}

	private native void n_onRoomAutoMatching (com.google.android.gms.games.multiplayer.realtime.Room p0);


	public void onRoomConnecting (com.google.android.gms.games.multiplayer.realtime.Room p0)
	{
		n_onRoomConnecting (p0);
	}

	private native void n_onRoomConnecting (com.google.android.gms.games.multiplayer.realtime.Room p0);

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
