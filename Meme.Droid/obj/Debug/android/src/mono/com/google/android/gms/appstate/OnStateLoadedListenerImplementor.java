package mono.com.google.android.gms.appstate;


public class OnStateLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.appstate.OnStateLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onStateConflict:(ILjava/lang/String;[B[B)V:GetOnStateConflict_ILjava_lang_String_arrayBarrayBHandler:Android.Gms.AppStates.IOnStateLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"n_onStateLoaded:(II[B)V:GetOnStateLoaded_IIarrayBHandler:Android.Gms.AppStates.IOnStateLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.AppStates.IOnStateLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnStateLoadedListenerImplementor.class, __md_methods);
	}


	public OnStateLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnStateLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.AppStates.IOnStateLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onStateConflict (int p0, java.lang.String p1, byte[] p2, byte[] p3)
	{
		n_onStateConflict (p0, p1, p2, p3);
	}

	private native void n_onStateConflict (int p0, java.lang.String p1, byte[] p2, byte[] p3);


	public void onStateLoaded (int p0, int p1, byte[] p2)
	{
		n_onStateLoaded (p0, p1, p2);
	}

	private native void n_onStateLoaded (int p0, int p1, byte[] p2);

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
