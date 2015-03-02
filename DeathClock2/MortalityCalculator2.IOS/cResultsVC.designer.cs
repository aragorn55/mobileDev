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
	[Register ("cResultsVC")]
	partial class cResultsVC
	{
		[Outlet]
		UIKit.UIButton btnExit { get; set; }

		[Outlet]
		UIKit.UIImageView imgLogo { get; set; }

		[Outlet]
		UIKit.UILabel lblYears { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnExit != null) {
				btnExit.Dispose ();
				btnExit = null;
			}

			if (imgLogo != null) {
				imgLogo.Dispose ();
				imgLogo = null;
			}

			if (lblYears != null) {
				lblYears.Dispose ();
				lblYears = null;
			}
		}
	}
}
