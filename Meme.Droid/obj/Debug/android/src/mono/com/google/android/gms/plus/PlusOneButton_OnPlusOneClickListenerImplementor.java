package mono.com.google.android.gms.plus;


public class PlusOneButton_OnPlusOneClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.plus.PlusOneButton.OnPlusOneClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPlusOneClick:(Landroid/content/Intent;)V:GetOnPlusOneClick_Landroid_content_Intent_Handler:Android.Gms.Plus.PlusOneButton/IOnPlusOneClickListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Plus.PlusOneButton/IOnPlusOneClickListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PlusOneButton_OnPlusOneClickListenerImplementor.class, __md_methods);
	}


	public PlusOneButton_OnPlusOneClickListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PlusOneButton_OnPlusOneClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Plus.PlusOneButton/IOnPlusOneClickListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPlusOneClick (android.content.Intent p0)
	{
		n_onPlusOneClick (p0);
	}

	private native void n_onPlusOneClick (android.content.Intent p0);

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
