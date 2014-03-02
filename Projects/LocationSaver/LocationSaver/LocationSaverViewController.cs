using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace LocationSaver
{
	public partial class LocationSaverViewController : UIViewController
	{
		List<string> MyLocations = new List<string>();

		public LocationSaverViewController () : base ("LocationSaverViewController", null)
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

			tvList.DataSource = new LocationDS (MyLocations);

			// Perform any additional setup after loading the view, typically from a nib.
			btnSave.TouchUpInside += delegate {
				MyLocations.Add("Test");
				tvList.ReloadData();
			};

		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

