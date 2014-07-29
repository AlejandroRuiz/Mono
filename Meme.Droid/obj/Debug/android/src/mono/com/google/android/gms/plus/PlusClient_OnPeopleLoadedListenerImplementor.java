package mono.com.google.android.gms.plus;


public class PlusClient_OnPeopleLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.plus.PlusClient.OnPeopleLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onPeopleLoaded:(Lcom/google/android/gms/common/ConnectionResult;Lcom/google/android/gms/plus/model/people/PersonBuffer;Ljava/lang/String;)V:GetOnPeopleLoaded_Lcom_google_android_gms_common_ConnectionResult_Lcom_google_android_gms_plus_model_people_PersonBuffer_Ljava_lang_String_Handler:Android.Gms.Plus.PlusClient/IOnPeopleLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Plus.PlusClient/IOnPeopleLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PlusClient_OnPeopleLoadedListenerImplementor.class, __md_methods);
	}


	public PlusClient_OnPeopleLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PlusClient_OnPeopleLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Plus.PlusClient/IOnPeopleLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onPeopleLoaded (com.google.android.gms.common.ConnectionResult p0, com.google.android.gms.plus.model.people.PersonBuffer p1, java.lang.String p2)
	{
		n_onPeopleLoaded (p0, p1, p2);
	}

	private native void n_onPeopleLoaded (com.google.android.gms.common.ConnectionResult p0, com.google.android.gms.plus.model.people.PersonBuffer p1, java.lang.String p2);

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
