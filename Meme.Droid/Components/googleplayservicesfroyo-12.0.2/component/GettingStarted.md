Requirements
============
This component is only for Xamarin.Android applications that target Android 2.2 (API level 8). In November, 2013 Google stopped supporting Android 2.2 in the newer versions of Google Play Services. Google has stopped supporting Froyo as of the revision 12 of the Google Play Services client libary. You can still use Google Play Services in existing Froyo application, but you won't get any of the bug fixes or features that appear in Google Play Services revision 13 or higher.

It is not necessary to manually manage the version of the Google Play Services client libary via the Android SDK manager. The Google Play Services component embeds metadata to identify what version of the Google Services client library it is bound to. When you add the component to your application, the correct version of the Google Play Services client library is downloaded and the component automatically binds to that, instead of the version that is installed by the Android SDK Manager.

This component also references and includes the [Xamarin.Android.Support.v4 (revision 18)](http://components.xamarin.com/view/xamandroidsupportv4-18) library, updated version of `Mono.Android.Support.v4`. The new library is not compatible with the old one, so application can no longer reference or use the older library.

To **test** your app when using the **Google Play services SDK**, you must use either:

* A compatible Android device that runs Android 2.2 or higher and includes Google Play Store.
* The **Android emulator** with an AVD that runs the **Google APIs** platform based on **API level 19**.

Ideally, you should develop and test your app on a variety of devices, including both phones and tablets.


Google Maps v2 API Key
----------------------

You must [obtain a new API Key](https://developers.google.com/maps/documentation/android/start#the_google_maps_api_key) for Google Maps v2, API keys from Google Maps v1 will not work. 

The location of the debug.keystore file that Xamarin.Android uses depends on your platform:

- **Windows Vista / Windows 7 / Windows 8**: `C:\Users\[USERNAME]\AppData\Local\Xamarin\Mono for Android\debug.keystore`
- **OSX** : `/Users/[USERNAME]/.local/share/Xamarin/Mono for Android/debug.keystore`

To obtain the SHA1 fingerprint of the debug keystore, you can use the `keytool` command that is a part of the JDK. This is an example of using `keytool` at the command-line:

    $ keytool -V -list -keystore debug.keystore -alias androiddebugkey -storepass android -keypass android


Showing a Map
=============

### MainActivity.cs

```csharp
using Android.Gms.Maps;
using Android.Support.V4.App;

// ...
public class YourActivity : FragmentActivity
{
	protected override void OnCreate (Bundle bundle)
	{
		base.OnCreate (bundle);

		// add map fragment to frame layout
		var mapFragment = new SupportMapFragment ();
		var fragmentTx = this.SupportFragmentManager.BeginTransaction ();
		fragmentTx.Add (Resource.Id.linearLayout1, mapFragment);
		fragmentTx.Commit ();

		// Set our view from the "main" layout resource
		SetContentView (Resource.Layout.Main);
	}
}
```

### Adding the API Key to your application

It goes in your application's manifest, contained in the file AndroidManifest.xml. From there, the Maps API reads the key value and passes it to the Google Maps server, which then confirms that you have access to Google Maps data.

In `AndroidManifest.xml`, add the following element as a child of the `<application>` element, by inserting it just before the closing tag `</application>`

```xml
<application android:label="@string/app_name">
		<!-- Put your Google Maps V2 API Key here. This key will not work for you.-->
		<!-- See https://developers.google.com/maps/documentation/android/start#obtaining_an_api_key -->
		<meta-data android:name="com.google.android.maps.v2.API_KEY" android:value="YourKey" />
</application>
```

Add the following elements to your manifest. Replace `com.example.mapdemo` with the package name of your application.

```xml
<permission
        android:name="com.example.mapdemo.permission.MAPS_RECEIVE"
        android:protectionLevel="signature"/>
<uses-permission android:name="com.example.mapdemo.permission.MAPS_RECEIVE"/>
```

### Specifying additional permissions

Besides permissions required by other parts of your application, you must add the following permissions to `AndroidManifest.xml` in order to use the Google Maps Android API:

```xml
<!-- We need to be able to download map tiles and access Google Play Services-->
<uses-permission android:name="android.permission.INTERNET" />
<!-- Allow the application to access Google web-based services. -->
<uses-permission android:name="com.google.android.providers.gsf.permission.READ_GSERVICES" />
<!-- Google Maps for Android v2 will cache map tiles on external storage -->
<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
<!-- Google Maps for Android v2 needs this permission so that it may check the connection state as it must download data -->
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
<!-- These are optional, but recommended. They will allow Maps to use the My Location provider. -->
<uses-permission android:name="android.permission.ACCESS_COARSE_LOCATION" />
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
```

### Requiring OpenGL ES version 2

Because version 2 of the Google Maps Android API requires OpenGL ES version 2, you must add a `<uses-feature>` element as a child of the `<manifest>` element in `AndroidManifest.xml`

```xml
<!-- Google Maps for Android v2 requires OpenGL ES v2 -->
	<uses-feature android:glEsVersion="0x00020000" android:required="true" />
```

Troubleshooting 
===============

In order to fix `java.lang.OutOfMemoryError: Java heap space` you will need to increase the **JavaMaximunHeapSize**, in order to do this you must edit the .csproj (Your Project File) in a
XML/Text editor, and add

	<PropertyGroup>
        <JavaMaximumHeapSize>1G</JavaMaximumHeapSize>
    </PropertyGroup>

* JavaMaximunHeapSize - This allows the overriding of the
  default java heapsize which is sometimes too low to compile
  some .jar files.
