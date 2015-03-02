using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MortalityCalculator.OB;
namespace MortalityCalculator2.IOS
{
	public partial class cPhysicalVC : UIViewController
	{
		NSDate _UserBday = new NSDate();
		cPerson _User;
		cLifeStyleVC _LifeStyleVC;
		public cPhysicalVC (cPerson oUser) : base ("cPhysicalVC", null)
		{
			_User = oUser;
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
			//txtFeet.Text = "6";
			//txtInches.Text = "0";
			//txtLbs.Text = "150";


			pickBDay.MaximumDate = NSDate.Now;
			//pickBDay.ValueChanged += delegate {
			//	UIAlertView MessageBox = new UIAlertView("Date",DateTime.SpecifyKind (pickBDay.Date, DateTimeKind.Utc).ToLocalTime().ToString() ,null,"Ok");
			//	MessageBox.Show();
		//	};
			txtFeet.ShouldReturn = delegate {
				txtFeet.ResignFirstResponder();
				return true;
			};
			txtInches.ShouldReturn = delegate {
				txtInches.ResignFirstResponder();
				return true;
			};
			txtLbs.ShouldReturn = delegate {
				txtLbs.ResignFirstResponder();
				return true;
			};
			// Perform any additional setup after loading the view, typically from a nib.
			btnLifeStyle.TouchUpInside += delegate {
				_UserBday = pickBDay.Date;

				
				double dFeet = -1;
				double dInches = -1;
				double dLbs = -1;


				if (double.TryParse(txtFeet.Text, out dFeet))
				    {

					if (double.TryParse(txtInches.Text, out dInches))
					    {

						if (double.TryParse(txtLbs.Text, out dLbs)){

							//openlifestyleView
							_User.BirthDate = DateTime.SpecifyKind(pickBDay.Date, DateTimeKind.Unspecified);
							_User.Height = (12.0 * dFeet) + dInches;
							_User.Weight = dLbs;
							if (segGender.SelectedSegment == 0)
							{
								_User.Sex = eGender.male;
							}
							else
							{
								_User.Sex = eGender.female;
							}

							_LifeStyleVC = new cLifeStyleVC (_User);
							NavigationController.PushViewController(_LifeStyleVC,true);

						}
					}
				}

				if ((dFeet == -1)||(dInches == -1)||(dLbs == -1)))
				{
					UIAlertView alert = new  UIAlertView("Error", "Please input a number into all fields", "OK", null);
					alert.Show(); 
				}

			};
		//	btnClear.TouchUpInside += delegate {
		//		conn.Execute("delete from Location");
		//		MyLocations.Clear();
		//		tvList.ReloadData();
		//	};
		}

		//public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
	//	{
			// Return true for supported orientations
		//	return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
	//	}
	}
}

