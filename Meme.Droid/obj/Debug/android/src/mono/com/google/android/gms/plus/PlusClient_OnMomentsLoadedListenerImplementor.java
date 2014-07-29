package mono.com.google.android.gms.plus;


public class PlusClient_OnMomentsLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.plus.PlusClient.OnMomentsLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMomentsLoaded:(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/moments/MomentBuffer;Ljava/lang/String;Ljava/lang/String;)V:GetOnMomentsLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_moments_MomentBuffer_Ljava_lang_String_Ljava_lang_String_Handler:Android.Gms.Plus.PlusClient/IOnMomentsLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Plus.PlusClient/IOnMomentsLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PlusClient_OnMomentsLoadedListenerImplementor.class, __md_methods);
	}


	public PlusClient_OnMomentsLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PlusClient_OnMomentsLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Plus.PlusClient/IOnMomentsLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onMomentsLoaded (com.google.android.gms.common.ConnectionResult p0, com.google.android.gms.plus.model.moments.MomentBuffer p1, java.lang.String p2, java.lang.String p3)
	{
		n_onMomentsLoaded (p0, p1, p2, p3);
	}

	private native void n_onMomentsLoaded (com.google.android.gms.common.ConnectionResult p0, com.google.android.gms.plus.model.moments.MomentBuffer p1, java.lang.String p2, java.lang.String p3);

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
