package xamarin.social;


public class ToolbarView
	extends android.widget.TableLayout
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Social.ToolbarView, Xamarin.Social.Android, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", ToolbarView.class, __md_methods);
	}


	public ToolbarView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ToolbarView.class)
			mono.android.TypeManager.Activate ("Xamarin.Social.ToolbarView, Xamarin.Social.Android, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public ToolbarView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == ToolbarView.class)
			mono.android.TypeManager.Activate ("Xamarin.Social.ToolbarView, Xamarin.Social.Android, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
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
