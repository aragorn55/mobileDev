using System;
using MonoTouch.UIKit;

namespace NavData
{
	public class MainNavigation: UINavigationController
	{
		Form FormViewController;
		public MainNavigation ()
		{
			FormViewController = new Form ();
			PushViewController (FormViewController, true);
		}
	}
}

