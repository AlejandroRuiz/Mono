package xamarin.social;


public class ShareActivity_AttachmentView
	extends android.widget.TableLayout
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Social.ShareActivity/AttachmentView, Xamarin.Social.Android, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", ShareActivity_AttachmentView.class, __md_methods);
	}


	public ShareActivity_AttachmentView (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ShareActivity_AttachmentView.class)
			mono.android.TypeManager.Activate ("Xamarin.Social.ShareActivity/AttachmentView, Xamarin.Social.Android, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public ShareActivity_AttachmentView (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == ShareActivity_AttachmentView.class)
			mono.android.TypeManager.Activate ("Xamarin.Social.ShareActivity/AttachmentView, Xamarin.Social.Android, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
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
