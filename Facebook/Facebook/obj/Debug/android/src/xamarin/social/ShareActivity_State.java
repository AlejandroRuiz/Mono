package xamarin.social;


public class ShareActivity_State
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Social.ShareActivity/State, Xamarin.Social.Android, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", ShareActivity_State.class, __md_methods);
	}


	public ShareActivity_State () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ShareActivity_State.class)
			mono.android.TypeManager.Activate ("Xamarin.Social.ShareActivity/State, Xamarin.Social.Android, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
