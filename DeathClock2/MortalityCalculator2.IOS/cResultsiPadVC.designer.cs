// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MortalityCalculator2.IOS
{
	[Register ("cResultsiPadVC")]
	partial class cResultsiPadVC
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnExit { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblYears { get; set; }
		
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
