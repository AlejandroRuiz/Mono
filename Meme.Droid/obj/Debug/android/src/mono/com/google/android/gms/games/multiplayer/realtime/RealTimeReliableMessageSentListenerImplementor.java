package mono.com.google.android.gms.games.multiplayer.realtime;


public class RealTimeReliableMessageSentListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.games.multiplayer.realtime.RealTimeReliableMessageSentListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onRealTimeMessageSent:(IILjava/lang/String;)V:GetOnRealTimeMessageSent_IILjava_lang_String_Handler:Android.Gms.Games.Multiplayer.Realtime.IRealTimeReliableMessageSentListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Games.Multiplayer.Realtime.IRealTimeReliableMessageSentListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RealTimeReliableMessageSentListenerImplementor.class, __md_methods);
	}


	public RealTimeReliableMessageSentListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RealTimeReliableMessageSentListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Games.Multiplayer.Realtime.IRealTimeReliableMessageSentListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onRealTimeMessageSent (int p0, int p1, java.lang.String p2)
	{
		n_onRealTimeMessageSent (p0, p1, p2);
	}

	private native void n_onRealTimeMessageSent (int p0, int p1, java.lang.String p2);

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
