using System;
using MonoTouch.UIKit;

namespace demo6
{
	public class NavController: UINavigationController
	{
		MainUI _MainViewController;
		public NavController ()
		{
			_MainViewController = new MainUI ();
			PushViewController (_MainViewController, true);
		}
	}
}

