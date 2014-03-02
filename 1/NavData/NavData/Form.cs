using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace NavData
{
	public partial class Form : UIViewController
	{
		public Form () : base ("Form", null)
		{
			Title="Fill-in Form";
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

			UIBarButtonItem btnAbout = new UIBarButtonItem ("About Me", UIBarButtonItemStyle.Plain, null);
			NavigationItem.SetRightBarButtonItem (btnAbout, true);

			btnAbout.Clicked += delegate {
				NavigationController.PushViewController(new About(),true);
			};

			txtName.ShouldReturn = delegate {
				txtName.ResignFirstResponder();
				return true;
			};

			txtAge.ShouldReturn = delegate {
				txtAge.ResignFirstResponder();
				return true;
			};


			btnSave.TouchUpInside += delegate {
				NSUserDefaults.StandardUserDefaults.SetString(txtName.Text,"Name");
				NSUserDefaults.StandardUserDefaults.SetString(txtAge.Text,"Age");
				NSUserDefaults.StandardUserDefaults.Synchronize();

				int Age;
				Int32.TryParse(txtAge.Text,out Age);
				NavigationController.PushViewController(new Report(txtName.Text,Age),true);
			};

			if (NSUserDefaults.StandardUserDefaults.StringForKey ("Name") != null) {
				txtName.Text = NSUserDefaults.StandardUserDefaults.StringForKey ("Name");
				txtAge.Text = NSUserDefaults.StandardUserDefaults.StringForKey ("Age");
			}


		}
	}
}

