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
	[Register ("cPhysicalVC")]
	partial class cPhysicalVC
	{
		[Outlet]
		UIKit.UIButton btnLifeStyle { get; set; }

		[Outlet]
		UIKit.UIDatePicker pickBDay { get; set; }

		[Outlet]
		UIKit.UISegmentedControl segGender { get; set; }

		[Outlet]
		UIKit.UITextField txtFeet { get; set; }

		[Outlet]
		UIKit.UITextField txtInches { get; set; }

		[Outlet]
		UIKit.UITextField txtLbs { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (segGender != null) {
				segGender.Dispose ();
				segGender = null;
			}

			if (pickBDay != null) {
				pickBDay.Dispose ();
				pickBDay = null;
			}

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

			if (btnLifeStyle != null) {
				btnLifeStyle.Dispose ();
				btnLifeStyle = null;
			}
		}
	}
}
