using System;
using Xamarin.Forms;

namespace SimpleListViewXamarinForms
{
	public class CitiesPage:ContentPage
	{
		public CitiesPage ()
		{
			Title = "Cities";
			var viewmodel = new CityViewModel ();
			var list = new ListView ();
			list.ItemsSource = viewmodel.Cities;
			var cell = new DataTemplate(typeof(ImageCell));
			cell.SetBinding (ImageCell.ImageSourceProperty, "Image");
			cell.SetBinding (ImageCell.TextProperty, "Name");
			cell.SetBinding (ImageCell.DetailProperty, "Country");
			list.ItemTemplate = cell;
			list.ItemTapped += (sender, args) =>
			{
				var city = args.Item as City;
				if (city == null)
					return;
				Navigation.PushAsync(new DetailPage(city));
				list.SelectedItem = null;
			};
			Content = list;
		}
	}
}