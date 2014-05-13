package mono.com.hoho.android.usbserial.util;


public class SerialInputOutputManager_ListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.hoho.android.usbserial.util.SerialInputOutputManager.Listener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onNewData:([B)V:GetOnNewData_arrayBHandler:Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager/IListenerInvoker, OTGLibrary\n" +
			"n_onRunError:(Ljava/lang/Exception;)V:GetOnRunError_Ljava_lang_Exception_Handler:Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager/IListenerInvoker, OTGLibrary\n" +
			"";
		mono.android.Runtime.register ("Com.Hoho.Android.Usbserial.Util.SerialInputOutputManager/IListenerImplementor, OTGLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SerialInputOutputManager_ListenerImplementor.class, __md_methods);
	}


	public void onNewData (byte[] p0)
	{
		n_onNewData (p0);
	}

	private native void n_onNewData (byte[] p0);


	public void onRunError (java.lang.Exception p0)
	{
		n_onRunError (p0);
	}

	private native void n_onRunError (java.lang.Exception p0);

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
