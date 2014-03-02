using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DateNight
{
	public partial class Coffee : UIViewController
	{
		Money _MyMoney;
		public Coffee (Money money) : base ("Coffee", null)
		{
			_MyMoney = money;
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

			btnSave.TouchUpInside += delegate {
				double Total;
				Double.TryParse(txtCoffee.Text,out Total);
				_MyMoney.CoffeeTotal = Total;
			};


		}
	}
}

