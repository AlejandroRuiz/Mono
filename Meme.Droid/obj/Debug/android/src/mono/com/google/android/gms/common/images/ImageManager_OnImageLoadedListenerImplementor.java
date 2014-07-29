package mono.com.google.android.gms.common.images;


public class ImageManager_OnImageLoadedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.common.images.ImageManager.OnImageLoadedListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onImageLoaded:(Landroid/net/Uri;Landroid/graphics/drawable/Drawable;)V:GetOnImageLoaded_Landroid_net_Uri_Landroid_graphics_drawable_Drawable_Handler:Android.Gms.Common.Images.ImageManager/IOnImageLoadedListenerInvoker, GooglePlayServicesFroyoLib\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Common.Images.ImageManager/IOnImageLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ImageManager_OnImageLoadedListenerImplementor.class, __md_methods);
	}


	public ImageManager_OnImageLoadedListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ImageManager_OnImageLoadedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Android.Gms.Common.Images.ImageManager/IOnImageLoadedListenerImplementor, GooglePlayServicesFroyoLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onImageLoaded (android.net.Uri p0, android.graphics.drawable.Drawable p1)
	{
		n_onImageLoaded (p0, p1);
	}

	private native void n_onImageLoaded (android.net.Uri p0, android.graphics.drawable.Drawable p1);

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
