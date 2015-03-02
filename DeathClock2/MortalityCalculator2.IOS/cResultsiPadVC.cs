using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MortalityCalculator.OB;

namespace MortalityCalculator2.IOS
{
	public partial class cResultsiPadVC : UIViewController
	{
		cPerson _User;
		cDeathCalculator oCalc;
		public cResultsiPadVC (cPerson voUser) : base ("cResultsiPadVC", null)
		{
			_User = voUser;
			oCalc = new cDeathCalculator ();
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
			lblYears.Text = oCalc.FindTimeLeft (_User).ToString ();
			imgLogo.Image = UIImage.FromBundle ("Images/clock.png");
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

