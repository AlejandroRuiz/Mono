using System;
using Xamarin.Forms;

namespace SimpleListViewXamarinForms
{
	public class DetailPage:ContentPage
	{
		public DetailPage (City city)
		{
			this.Title = city.Name;
			var image = new Image{
				Source = city.Image
			};
			var detailText = new Label{
				Text = city.Country
			};
			Content = new ScrollView
			{
				Padding = 10,
				Content = new StackLayout{
					Children = {image,detailText} 
				}
			};
		}
	}
}