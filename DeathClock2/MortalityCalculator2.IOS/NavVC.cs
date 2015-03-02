using System;
using MonoTouch.UIKit;
using MortalityCalculator.OB;
namespace MortalityCalculator2.IOS
{
	public class NavViewController: UINavigationController
	{
		cPhysicalVC PhysicalViewController;
		cPerson oUser;
		cPhysicaliPadVC PhysicaliPadVC;

		public NavViewController ()

		{
			oUser = new cPerson ();
			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad) {
				PhysicaliPadVC = new cPhysicaliPadVC (oUser);
				PushViewController (PhysicaliPadVC, true);
			} else {
				PhysicalViewController = new cPhysicalVC (oUser);
				PushViewController (PhysicalViewController, true);
			}

		}
	}
}

