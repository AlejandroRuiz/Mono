package mono.com.google.android.gms.appstate;


public class OnStateDeletedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.appstate.OnStateDeletedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onStateDeleted:(II)V:GetOnStateDeleted_IIHandler:Android.Gms.AppStates.IOnStateDeletedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.AppStates.IOnStateDeletedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnStateDeletedListenerImplementor.class, __md_methods);
	}


	public OnStateDeletedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == OnStateDeletedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.AppStates.IOnStateDeletedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onStateDeleted (int p0, int p1)
	{
		n_onStateDeleted (p0, p1);
	}

	private native void n_onStateDeleted (int p0, int p1);

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
