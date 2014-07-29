package mono.com.google.android.gms.games.multiplayer.realtime;


public class RoomUpdateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.multiplayer.realtime.RoomUpdateListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onJoinedRoom:(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V:GetOnJoinedRoom_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onLeftRoom:(ILjava/lang/String;)V:GetOnLeftRoom_ILjava_lang_String_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onRoomConnected:(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V:GetOnRoomConnected_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onRoomCreated:(ILcom/google/android/gms/games/multiplayer/realtime/Room;)V:GetOnRoomCreated_ILcom_google_android_gms_games_multiplayer_realtime_Room_Handler:Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RoomUpdateListenerImplementor.class, __md_methods);
	}


	public RoomUpdateListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RoomUpdateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.Multiplayer.Realtime.IRoomUpdateListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onJoinedRoom (int p0, com.google.android.gms.games.multiplayer.realtime.Room p1)
	{
		n_onJoinedRoom (p0, p1);
	}

	private native void n_onJoinedRoom (int p0, com.google.android.gms.games.multiplayer.realtime.Room p1);


	public void onLeftRoom (int p0, java.lang.String p1)
	{
		n_onLeftRoom (p0, p1);
	}

	private native void n_onLeftRoom (int p0, java.lang.String p1);


	public void onRoomConnected (int p0, com.google.android.gms.games.multiplayer.realtime.Room p1)
	{
		n_onRoomConnected (p0, p1);
	}

	private native void n_onRoomConnected (int p0, com.google.android.gms.games.multiplayer.realtime.Room p1);


	public void onRoomCreated (int p0, com.google.android.gms.games.multiplayer.realtime.Room p1)
	{
		n_onRoomCreated (p0, p1);
	}

	private native void n_onRoomCreated (int p0, com.google.android.gms.games.multiplayer.realtime.Room p1);

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
