package xamarin.forms.platform.android;


public class FrameRenderer_FrameDrawable
	extends android.graphics.drawable.Drawable
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_isStateful:()Z:GetIsStatefulHandler\n" +
			"n_onStateChange:([I)Z:GetOnStateChange_arrayIHandler\n" +
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_setAlpha:(I)V:GetSetAlpha_IHandler\n" +
			"n_getOpacity:()I:GetGetOpacityHandler\n" +
			"n_setColorFilter:(Landroid/graphics/ColorFilter;)V:GetSetColorFilter_Landroid_graphics_ColorFilter_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.FrameRenderer/FrameDrawable, Xamarin.Forms.Platform.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FrameRenderer_FrameDrawable.class, __md_methods);
	}


	public FrameRenderer_FrameDrawable () throws java.lang.Throwable
	{
		super ();
		if (getClass () == FrameRenderer_FrameDrawable.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.FrameRenderer/FrameDrawable, Xamarin.Forms.Platform.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean isStateful ()
	{
		return n_isStateful ();
	}

	private native boolean n_isStateful ();


	public boolean onStateChange (int[] p0)
	{
		return n_onStateChange (p0);
	}

	private native boolean n_onStateChange (int[] p0);


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);


	public void setAlpha (int p0)
	{
		n_setAlpha (p0);
	}

	private native void n_setAlpha (int p0);


	public int getOpacity ()
	{
		return n_getOpacity ();
	}

	private native int n_getOpacity ();


	public void setColorFilter (android.graphics.ColorFilter p0)
	{
		n_setColorFilter (p0);
	}

	private native void n_setColorFilter (android.graphics.ColorFilter p0);

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
