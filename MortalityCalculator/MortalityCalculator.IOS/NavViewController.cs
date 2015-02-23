using System;
using MonoTouch.UIKit;
using MortalityCalculator.OB;
namespace MortalityCalculator.IOS
{
	public class NavViewController: UINavigationController
	{
		cPhysicalVC PhysicalViewController;
		cPerson oUser;
		public NavViewController ()
		{
			oUser = new cPerson ();
			PhysicalViewController = new cPhysicalVC (oUser);
			PushViewController (PhysicalViewController, true);
		}
	}
}

