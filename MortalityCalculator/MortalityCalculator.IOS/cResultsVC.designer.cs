// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MortalityCalculator.IOS
{
	[Register ("cResultsVC")]
	partial class cResultsVC
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnExit { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblDays { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblYears { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgLogo != null) {
				imgLogo.Dispose ();
				imgLogo = null;
			}

			if (lblYears != null) {
				lblYears.Dispose ();
				lblYears = null;
			}

			if (lblDays != null) {
				lblDays.Dispose ();
				lblDays = null;
			}

			if (btnExit != null) {
				btnExit.Dispose ();
				btnExit = null;
			}
		}
	}
}
