package meme.droid.helpers;


public class Fragment1
	extends android.support.v4.app.Fragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onCreateOptionsMenu:(Landroid/view/Menu;Landroid/view/MenuInflater;)V:GetOnCreateOptionsMenu_Landroid_view_Menu_Landroid_view_MenuInflater_Handler\n" +
			"";
		mono.android.Runtime.register ("Meme.Droid.Helpers.Fragment1, Meme.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Fragment1.class, __md_methods);
	}


	public Fragment1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Fragment1.class)
			mono.android.TypeManager.Activate ("Meme.Droid.Helpers.Fragment1, Meme.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public void onCreateOptionsMenu (android.view.Menu p0, android.view.MenuInflater p1)
	{
		n_onCreateOptionsMenu (p0, p1);
	}

	private native void n_onCreateOptionsMenu (android.view.Menu p0, android.view.MenuInflater p1);

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
