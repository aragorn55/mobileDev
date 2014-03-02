using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace NavData
{
	public partial class Report : UIViewController
	{
		string _Name;
		int _Age;

		public Report (string Name, int Age) : base ("Report", null)
		{
			Title = "Report";
			_Name = Name;
			_Age = Age;
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

			lblName.Text = _Name;
			lblAge.Text = _Age.ToString();
		}
	}
}

