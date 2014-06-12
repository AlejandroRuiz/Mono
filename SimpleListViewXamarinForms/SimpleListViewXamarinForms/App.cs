using System;
using Xamarin.Forms;

namespace SimpleListViewXamarinForms
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			var cities = new CitiesPage ();
			return new NavigationPage (cities);
		}
	}
}

