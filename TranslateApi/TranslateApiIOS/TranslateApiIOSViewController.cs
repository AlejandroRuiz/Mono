using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TranslateApi;

namespace TranslateApiIOS
{
	public partial class TranslateApiIOSViewController : UIViewController
	{
		public TranslateApiIOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			myButton.SetTitle ("hello".t(), UIControlState.Normal);
			// Perform any additional setup after loading the view, typically from a nib.
			myButton.TouchUpInside += (sender, e) => {
				myButton.SetTitle("bye".t(), UIControlState.Normal);
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

