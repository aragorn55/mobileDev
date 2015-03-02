using System;
using CoreGraphics;
using Foundation;
using UIKit;
using MortalityCalculator.OB;

namespace MortalityCalculator2.IOS
{
	public partial class cPhysicaliPadVC : UIViewController
	{
		NSDate _UserBday = new NSDate ();
		cPerson _User;
		cResultsiPadVC _ResultsiPadVC;

		public cPhysicaliPadVC (cPerson oUser) : base ("cPhysicaliPadVC", null)
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
			//	imgLogo.Image
			//txtFeet.Text = "6";
			//txtInches.Text = "0";
			//txtLbs.Text = "150";
			//txtSleep.Text = "8";
			//txtCigarettes.Text = "0";
			pickBDay.MaximumDate = NSDate.Now;
			imgLogo.Image = UIImage.FromBundle ("Images/life.png");
			//pickBDay.ValueChanged += delegate {
			//	UIAlertView MessageBox = new UIAlertView("Date",DateTime.SpecifyKind (pickBDay.Date, DateTimeKind.Utc).ToLocalTime().ToString() ,null,"Ok");
			//	MessageBox.Show();
			//	};
			txtFeet.ShouldReturn = delegate {
				txtFeet.ResignFirstResponder ();
				return true;
			};
			txtInches.ShouldReturn = delegate {
				txtInches.ResignFirstResponder ();
				return true;
			};
			txtLbs.ShouldReturn = delegate {
				txtLbs.ResignFirstResponder ();
				return true;
			};
			txtSleep.ShouldReturn = delegate {
				txtSleep.ResignFirstResponder ();
				return true;
			};
			txtCigarettes.ShouldReturn = delegate {
				txtCigarettes.ResignFirstResponder ();
				return true;
			};
			// Perform any additional setup after loading the view, typically from a nib.

			btnCalculate.TouchUpInside += delegate {

				_UserBday = pickBDay.Date;

				double dFeet = -1;
				double dInches = -1;
				double dLbs = -1;
				double dSleep = -1;
				double dCigarettes = -1;

				if (double.TryParse (txtFeet.Text, out dFeet)) {

					if (double.TryParse (txtInches.Text, out dInches)) {

						if (double.TryParse (txtLbs.Text, out dLbs)) {
							if (double.TryParse (txtSleep.Text, out dSleep)) {

								if (double.TryParse (txtCigarettes.Text, out dCigarettes)) {

									_User.HrsSleep = dSleep;
									_User.CigPerDay = dCigarettes;
									//openlifestyleView
									_User.BirthDate = DateTime.SpecifyKind (pickBDay.Date, DateTimeKind.Unspecified);
									_User.Height = (12.0 * dFeet) + dInches;
									_User.Weight = dLbs;
									if (segGender.SelectedSegment == 0) {
										_User.Sex = eGender.male;
									} else {
										_User.Sex = eGender.female;
									}

									_ResultsiPadVC = new cResultsiPadVC (_User);
									NavigationController.PushViewController (_ResultsiPadVC, true);




								}
							}

						}
					}

				
				}
				if ((dFeet == -1) || (dInches == -1) || (dLbs == -1) || (dSleep == -1) || (dCigarettes == -1)) {
					UIAlertView alert = new  UIAlertView ("Error", "Please input a number into all fields", null, "OK", null);
					alert.Show (); 
				}
				// Perform any additional setup after loading the view, typically from a nib.
			};
		}
	}
}
