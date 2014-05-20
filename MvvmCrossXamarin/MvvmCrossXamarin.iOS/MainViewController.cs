
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MvvmXamarin.iOS
{
	public partial class MainViewController : UIViewController
	{
		public MainViewController () : base ()
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		Model viewModel=null;
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
            View.BackgroundColor = UIColor.Gray;
			// Perform any additional setup after loading the view, typically from a nib.
			viewModel = new Model ();
			UILabel lbl = new UILabel (new RectangleF(0,0,320, 50));
			lbl.Text = viewModel.Text;
			lbl.AdjustsFontSizeToFitWidth = true;
			UITextView et = new UITextView (new RectangleF (0, 60, 320, 50));
			et.Text = viewModel.Text;
			et.Changed += (object sender, EventArgs e) => {
				viewModel.Text = et.Text;
			};
            UIButton btn = new UIButton(new RectangleF(0, 120, 320, 50));
            btn.SetTitle(viewModel.TimesString, UIControlState.Normal);
            btn.TouchUpInside += (s,e) => viewModel.ClickEvent.Execute(null);
            btn.ShowsTouchWhenHighlighted = true;
			viewModel.PropertyChanged += (object sender, System.ComponentModel.PropertyChangedEventArgs e) => 
			{
                if (e.PropertyName == "Text")
                    lbl.Text = viewModel.Text;
                else if (e.PropertyName == "TimesString")
                    btn.SetTitle(viewModel.TimesString, UIControlState.Normal);
			};
			View.Add (lbl);
			View.Add (et);
            View.Add (btn);
		}
	}
}

