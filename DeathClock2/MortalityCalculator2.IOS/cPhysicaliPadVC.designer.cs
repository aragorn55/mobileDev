// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MortalityCalculator2.IOS
{
	[Register ("cPhysicaliPadVC")]
	partial class cPhysicaliPadVC
	{
		[Outlet]
		UIKit.UIButton btnCalculate { get; set; }

		[Outlet]
		UIKit.UIImageView imgLogo { get; set; }

		[Outlet]
		UIKit.UIDatePicker pickBDay { get; set; }

		[Outlet]
		UIKit.UISegmentedControl segGender { get; set; }

		[Outlet]
		UIKit.UITextField txtCigarettes { get; set; }

		[Outlet]
		UIKit.UITextField txtFeet { get; set; }

		[Outlet]
		UIKit.UITextField txtInches { get; set; }

		[Outlet]
		UIKit.UITextField txtLbs { get; set; }

		[Outlet]
		UIKit.UITextField txtSleep { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtFeet != null) {
				txtFeet.Dispose ();
				txtFeet = null;
			}

			if (txtInches != null) {
				txtInches.Dispose ();
				txtInches = null;
			}

			if (txtLbs != null) {
				txtLbs.Dispose ();
				txtLbs = null;
			}

			if (pickBDay != null) {
				pickBDay.Dispose ();
				pickBDay = null;
			}

			if (segGender != null) {
				segGender.Dispose ();
				segGender = null;
			}

			if (txtSleep != null) {
				txtSleep.Dispose ();
				txtSleep = null;
			}

			if (txtCigarettes != null) {
				txtCigarettes.Dispose ();
				txtCigarettes = null;
			}

			if (imgLogo != null) {
				imgLogo.Dispose ();
				imgLogo = null;
			}

			if (btnCalculate != null) {
				btnCalculate.Dispose ();
				btnCalculate = null;
			}
		}
	}
}
