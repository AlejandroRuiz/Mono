using System;
#if __IOS__
using MonoTouch.Foundation;
#endif
#if __ANDROID__
using Android.Content;
#endif

namespace TranslateApi
{
	public static class ApiTExtensions
	{
		#if __IOS__
		public static string t(this string tlt)
		{
			return NSBundle.MainBundle.LocalizedString(tlt, "", "") ?? "Not Found";
		}
		#endif
		#if __ANDROID__
		public static string t(this string tlt, Context ctx)
		{
			try
			{
				return ctx.Resources.GetString(ctx.Resources.GetIdentifier (tlt, "string", ctx.PackageName)) ?? "Not Found";
			}
			catch(Exception) {
				return "Not Found";
			}
		}
		#endif
	}
}