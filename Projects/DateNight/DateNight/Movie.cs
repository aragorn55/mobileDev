using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DateNight
{
	public partial class Movie : UIViewController
	{
		public Movie () : base ("Movie", null)
		{
			Title = "Movie";
			TabBarItem.Image = UIImage.FromBundle ("Images/movie");
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
			imgLogo.Image = UIImage.FromBundle ("Images/movietime");

			txtMovie.ShouldReturn = delegate {
				txtMovie.ResignFirstResponder();
				return true;
			};
		}
	}
}

