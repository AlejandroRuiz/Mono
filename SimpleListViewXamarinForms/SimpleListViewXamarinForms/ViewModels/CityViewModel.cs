using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SimpleListViewXamarinForms
{
	public class CityViewModel
	{
		public ObservableCollection<City> Cities;
		public CityViewModel ()
		{
			Cities = new ObservableCollection<City> ();
			Cities.Add (new City{
				Name = "Guadalajara",
				Country = "Mexico",
				Image = "Gdl.jpg"
			});
			Cities.Add(new City{
				Name = "Austin",
				Country = "USA",
				Image = "Aus.jpg"
			});
			Cities.Add(new City{
				Name = "Tokio",
				Country = "Japan",
				Image = "Tok.jpg"
			});
		}
	}
}