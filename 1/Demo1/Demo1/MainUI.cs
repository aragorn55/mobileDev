using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Demo1
{
	public partial class MainUI : UIViewController
	{
		public MainUI () : base ("MainUI", null)
		{
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
			btnAdd.TouchUpInside += delegate {
				double operA=0;
				double operB=0;
				Double.TryParse(txtOperA.Text,out operA);
				Double.TryParse(txtOperB.Text,out operB);

				lblDisplay.Text = (operA + operB).ToString();
			};

			btnClear.TouchUpInside += delegate {
				lblDisplay.Text = String.Empty;
			};
		}
	}
}









