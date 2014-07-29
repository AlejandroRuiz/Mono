package meme.droid.helpers;


public class MyActionBarDrawerToggle
	extends android.support.v4.app.ActionBarDrawerToggle
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onDrawerClosed:(Landroid/view/View;)V:GetOnDrawerClosed_Landroid_view_View_Handler\n" +
			"n_onDrawerOpened:(Landroid/view/View;)V:GetOnDrawerOpened_Landroid_view_View_Handler\n" +
			"n_onDrawerSlide:(Landroid/view/View;F)V:GetOnDrawerSlide_Landroid_view_View_FHandler\n" +
			"n_onDrawerStateChanged:(I)V:GetOnDrawerStateChanged_IHandler\n" +
			"";
		mono.android.Runtime.register ("Meme.Droid.Helpers.MyActionBarDrawerToggle, Meme.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyActionBarDrawerToggle.class, __md_methods);
	}


	public MyActionBarDrawerToggle (android.app.Activity p0, android.support.v4.widget.DrawerLayout p1, int p2, int p3, int p4) throws java.lang.Throwable
	{
		super (p0, p1, p2, p3, p4);
		if (getClass () == MyActionBarDrawerToggle.class)
			mono.android.TypeManager.Activate ("Meme.Droid.Helpers.MyActionBarDrawerToggle, Meme.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Support.V4.Widget.DrawerLayout, Xamarin.Android.Support.v4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3, p4 });
	}


	public void onDrawerClosed (android.view.View p0)
	{
		n_onDrawerClosed (p0);
	}

	private native void n_onDrawerClosed (android.view.View p0);


	public void onDrawerOpened (android.view.View p0)
	{
		n_onDrawerOpened (p0);
	}

	private native void n_onDrawerOpened (android.view.View p0);


	public void onDrawerSlide (android.view.View p0, float p1)
	{
		n_onDrawerSlide (p0, p1);
	}

	private native void n_onDrawerSlide (android.view.View p0, float p1);


	public void onDrawerStateChanged (int p0)
	{
		n_onDrawerStateChanged (p0);
	}

	private native void n_onDrawerStateChanged (int p0);

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
