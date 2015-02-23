using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MortalityCalculatorIOS.OB;
namespace MortalityCalculator
{
	public partial class MainUI : UIViewController
	{
		public MainUI () : base ("MainUI", null)
		{
			cPerson oUser;
			oUser = new cPerson ();
			cDeathCalculator dCalc;
			dCalc = new cDeathCalculator ();
			oUser.Age = 28;
			oUser.CigPerDay = 0;
			dCalc.

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
	}
}

