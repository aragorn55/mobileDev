using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DateNight
{
	public partial class Total : UIViewController
	{
		Money _MyMoney;
		public Total (Money money) : base ("Total", null)
		{
			_MyMoney = money;
			Title = "Total";
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

		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			lblTotal.Text = _MyMoney.GetTotalCost ().ToString();
		}
	}
}

