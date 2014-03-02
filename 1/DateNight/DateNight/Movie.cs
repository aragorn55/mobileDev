using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DateNight
{
	public partial class Movie : UIViewController
	{
		Money _MyMoney;
		public Movie (Money money) : base ("Movie", null)
		{
			_MyMoney = money;
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

			btnSave.TouchUpInside += delegate {
				double Total;
				Double.TryParse(txtMovie.Text,out Total);
				_MyMoney.MovieTotal = Total;
			};
		}
	}
}

