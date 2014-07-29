package mono.com.google.android.gms.plus;


public class PlusClient_OnAccessRevokedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.plus.PlusClient.OnAccessRevokedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAccessRevoked:(Lcom/google/android/gms/common/ConnectionResult;)V:GetOnAccessRevoked_Lcom_google_android_gms_common_ConnectionResult_Handler:Android.Gms.Plus.PlusClient/IOnAccessRevokedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Plus.PlusClient/IOnAccessRevokedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PlusClient_OnAccessRevokedListenerImplementor.class, __md_methods);
	}


	public PlusClient_OnAccessRevokedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PlusClient_OnAccessRevokedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Plus.PlusClient/IOnAccessRevokedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAccessRevoked (com.google.android.gms.common.ConnectionResult p0)
	{
		n_onAccessRevoked (p0);
	}

	private native void n_onAccessRevoked (com.google.android.gms.common.ConnectionResult p0);

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
