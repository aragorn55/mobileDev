using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DateNight
{
	public partial class Shopping : UIViewController
	{
		public Shopping () : base ("Shopping", null)
		{
			Title = "Shopping";
			TabBarItem.Image = UIImage.FromBundle ("Images/shopping");
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
			imgLogo.Image = UIImage.FromBundle ("Images/shoppingtime");

			txtShopping.ShouldReturn = delegate {
				txtShopping.ResignFirstResponder();
				return true;
			};
		}
	}
}

