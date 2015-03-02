using System;
using System.Drawing;
using DeathClock.OB;
namespace DeathClock.Droid
{
	public partial class cResultsVC 
	{
		cPerson _User;
		cDeathCalculator oCalc;
		public cResultsVC (cPerson voUser)
		{
		_User = voUser;
			oCalc = new cDeathCalculator ();
		
		}
		//imgLogo
		//lblYears
		//lblDays
		//btnExit
		//




//		public override void ViewDidLoad ()
//		{
//			base.ViewDidLoad ();
//
//			lblYears.Text = oCalc.FindTimeLeft (_User).ToString ();
//			imgLogo.Image = UIImage.FromBundle ("Images/clock.png");
//			// Perform any additional setup after loading the view, typically from a nib.
//		}
	}
}

