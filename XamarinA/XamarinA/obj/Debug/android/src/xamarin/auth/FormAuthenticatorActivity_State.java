package xamarin.auth;


public class FormAuthenticatorActivity_State
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Auth.FormAuthenticatorActivity/State, Xamarin.Auth.Android, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null", FormAuthenticatorActivity_State.class, __md_methods);
	}


	public FormAuthenticatorActivity_State () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FormAuthenticatorActivity_State.class)
			mono.android.TypeManager.Activate ("Xamarin.Auth.FormAuthenticatorActivity/State, Xamarin.Auth.Android, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
