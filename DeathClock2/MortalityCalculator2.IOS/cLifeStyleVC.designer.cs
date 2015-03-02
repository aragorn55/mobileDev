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
	[Register ("cLifeStyleVC")]
	partial class cLifeStyleVC
	{
		[Outlet]
		UIKit.UIButton btnCalculate { get; set; }

		[Outlet]
		UIKit.UIImageView imgLifestyle { get; set; }

		[Outlet]
		UIKit.UITextField txtCigarettes { get; set; }

		[Outlet]
		UIKit.UITextField txtSleep { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgLifestyle != null) {
				imgLifestyle.Dispose ();
				imgLifestyle = null;
			}

			if (txtCigarettes != null) {
				txtCigarettes.Dispose ();
				txtCigarettes = null;
			}

			if (txtSleep != null) {
				txtSleep.Dispose ();
				txtSleep = null;
			}

			if (btnCalculate != null) {
				btnCalculate.Dispose ();
				btnCalculate = null;
			}
		}
	}
}
