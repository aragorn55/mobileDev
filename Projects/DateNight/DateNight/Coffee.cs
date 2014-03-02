using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DateNight
{
	public partial class Coffee : UIViewController
	{
		public Coffee () : base ("Coffee", null)
		{
			Title = "Coffee";
			TabBarItem.Image = UIImage.FromBundle ("Images/coffee");
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
			imgLogo.Image = UIImage.FromBundle ("Images/coffeetime");

			txtCoffee.ShouldReturn = delegate {
				txtCoffee.ResignFirstResponder();
				return true;
			};

		}
	}
}

