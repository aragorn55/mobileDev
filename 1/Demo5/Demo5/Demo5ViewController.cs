using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Demo5
{
	public partial class Demo5ViewController : UIViewController
	{
		public Demo5ViewController () : base ("Demo5ViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			MyScrollView.Frame = new RectangleF (0, 0, 320, 460);
			MyScrollView.ContentSize = new SizeF (320, 700);

			//MyScrollView.BackgroundColor = UIColor.FromPatternImage (UIImage.FromBundle ("Images/BartSimpson.gif"));


		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

